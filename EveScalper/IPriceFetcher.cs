using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveScalper
{
    public interface IPriceFetcher
    {
        Security grabItem(int id, int station, int age);
        Security grabRandomItem(int station, int age);
    }
}
