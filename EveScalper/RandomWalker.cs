using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveScalper
{
    // FIXME: Figure out how to better control the list of securities
    // The problem is that IList cannot be IReadOnlyList here as it is modified
    // But if any other code alters the length of the list
    // things will break...
    // Defensive copy maybe? Eh.. maybe.
    public class RandomWalker
    {
        private IList<int> ids;
        private int max;
        private Random randomNumberGenerator;

        public RandomWalker(IList<int> ids)
        {
            this.ids = ids;
            this.randomNumberGenerator = new Random(
                (int)DateTime.Now.Ticks & 0x0000FFFF);
            this.max = this.ids.Count;
        }

        // Precondition: List must not be empty
        public int pick()
        {
            int randomNumber = 0;

            // Restart if done
            if (this.max == 0)
            {
                this.max = this.ids.Count;
            }

            randomNumber = this.randomNumberGenerator.Next() % this.max;
            this.max--;

            int temporary = this.ids[max];
            this.ids[max] = this.ids[randomNumber];
            this.ids[randomNumber] = temporary;

            return this.ids.ElementAt(max);
        }

        public void reset()
        {
            this.max = this.ids.Count;
        }
    }
}
