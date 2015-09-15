using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveScalper
{
    public interface IPopulator
    {
        event EventHandler<SecurityArgs> OnSecurityUpdate;

        void setup();
        void start();
        void fetch(object o, EventArgs e);
        void stop();
    }
}
