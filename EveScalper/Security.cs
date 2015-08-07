using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveScalper
{
    public class Security
    {
        public readonly string Name;
        public readonly double Buy;
        public readonly double Sell;
        public readonly double Spread;
        public readonly double Percentage;
        public readonly long Volume;
        public readonly double Capitalization;

        public Security(string name,
          double buy,
          double sell,
          long volume)
        {
            this.Name = name;
            this.Buy = buy;
            this.Sell = sell;
            this.Volume = volume;

            this.Spread = sell - buy;
            this.Percentage = (sell / buy) - 1.0;

            this.Capitalization = Spread * volume;
        }

        public Security(string name,
            double buy,
            double sell,
            double spread,
            double percentage,
            long volume,
            double capitalization)
        {
            this.Name = name;
            this.Buy = buy;
            this.Sell = sell;
            this.Spread = spread;
            this.Percentage = percentage;
            this.Volume = volume;
            this.Capitalization = capitalization;
        }
    }
}
