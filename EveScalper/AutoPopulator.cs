using System;
using System.ComponentModel;
using System.Threading;

namespace EveScalper
{
    public class AutoPopulator : IPopulator
    {
        public event EventHandler<SecurityArgs> OnSecurityUpdate;

        private bool running;
        private readonly PriceFetcher fetcher;
        private readonly int station;
        private readonly int age;
        private readonly int delay;
        private BackgroundWorker worker;

        private Security mostRecent;

        public static IPopulator create(PriceFetcher fetcher,
            int station,
            int age,
            int delay)
        {
            return new AutoPopulator(fetcher, station, age, delay);
        }

        public AutoPopulator(PriceFetcher fetcher,
            int station,
            int age,
            int delay)
        {
            this.running = false;
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
            SecurityArgs eventArguments = new SecurityArgs(this.mostRecent);
            this.OnSecurityUpdate(this, eventArguments);
            if(true == this.running)
            {
                this.worker.RunWorkerAsync();
            }
        }

        public void start()
        {
            if (false == this.running)
            {
                this.running = true;
                this.worker.RunWorkerAsync();
            }
        }

        public void fetch(object o, EventArgs e)
        {
            this.mostRecent = fetcher.grabRandomItem(this.station, this.age);

            Thread.Sleep(this.delay);
        }

        public void stop()
        {
            if (true == this.running)
            {
                this.running = false;
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
