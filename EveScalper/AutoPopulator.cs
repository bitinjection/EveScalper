using System;
using System.ComponentModel;
using System.Threading;

namespace EveScalper
{
    public class AutoPopulator : IPopulator
    {
        public event EventHandler<SecurityArgs> OnSecurityUpdate;
        public bool Running { get; private set; }
        public Security MostRecent { get; private set; }

        private readonly IPriceFetcher fetcher;
        private readonly int station;
        private readonly int age;
        private readonly int delay;
        private BackgroundWorker worker;

        public static IPopulator create(IPriceFetcher fetcher,
            int station,
            int age,
            int delay)
        {
            return new AutoPopulator(fetcher, station, age, delay);
        }

        public AutoPopulator(IPriceFetcher fetcher,
            int station,
            int age,
            int delay)
        {
            this.Running = false;
            this.fetcher = fetcher;
            this.station = station;
            this.age = age;
            this.delay = delay;
        }

        // TODO: FIX THIS--Object invalid unless this is called!
        public void setup()
        {
            this.worker = new BackgroundWorker();
            this.worker.DoWork += this.fetch;
            this.worker.RunWorkerCompleted += notifyFinished;
        }

        private void notifyFinished(object o, EventArgs e)
        {
            SecurityArgs eventArguments = new SecurityArgs(this.MostRecent);
            this.OnSecurityUpdate(this, eventArguments);

            if(true == this.Running)
            {
                this.worker.RunWorkerAsync();
            }
        }

        public void start()
        {
            if (false == this.Running)
            {
                this.Running = true;
                this.worker.RunWorkerAsync();
            }
        }

        public void fetch(object o, EventArgs e)
        {
            this.MostRecent = fetcher.grabRandomItem(this.station, this.age);

            Thread.Sleep(this.delay);
        }

        public void stop()
        {
            if (true == this.Running)
            {
                this.Running = false;
                this.worker.DoWork -= this.fetch;
                this.worker.RunWorkerCompleted -= notifyFinished;
            }
        }
    }

    public class SecurityArgs : EventArgs
    {
        public readonly Security security;

        public SecurityArgs(Security security)
        {
            this.security = security;
        }
    }
}
