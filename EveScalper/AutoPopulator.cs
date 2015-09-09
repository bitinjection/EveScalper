using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveScalper
{
    public class AutoPopulator
    {
        private bool running;
        private readonly RandomWalker walker; 

        public AutoPopulator(RandomWalker walker)
        {
            this.walker = walker;
        }

        public void start()
        {
            this.running = true;

        }

        public void stop()
        {
            this.running = false;
        }
    }
}
