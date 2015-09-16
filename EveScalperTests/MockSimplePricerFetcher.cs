using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using EveScalper;

namespace EveScalper.Tests
{
    public class MockSimplePriceFetcher  : IPriceFetcher
    {
        private IList<Security> items;

        public MockSimplePriceFetcher()
        {
            this.items = new List<Security>();

            this.items.Add(new Security(1, "Test Item 1", 5.0, 50.0, 100));
        }

        public Security grabItem(int id, int station, int age)
        {
            return this.items.ElementAt(id);
        }

        public Security grabRandomItem(int station, int age)
        {
            Random random = new Random();
            int id =
                random.Next((int)DateTime.Now.Ticks & 0x0000FFFF) % this.items.Count;

            return this.items.ElementAt(id);
        }
    }
}
