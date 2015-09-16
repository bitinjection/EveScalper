using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EveScalper
{
    using SystemPair = Tuple<string, int>;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IList<Security> securities = new List<Security>();

            IGameData database =
                new StaticDataExport("sqlite-latest.sqlite");

            IReadOnlyList<int> ids = database.inventoryIds();
            IReadOnlyList<SystemPair> systems = database.systemList();

            IPriceWalker walker = new RandomWalker(new List<int>(ids));

            PriceFetcher fetcher = new PriceFetcher(walker,
                EveCentralParameters.downloadPrices);

            // Improve the clarity of this actually-simple task...
            Func<PriceFetcher, Func<int, int, int, IPopulator>>
                populatorFactory = (f) =>
                (s, a, d) =>
                {
                    IPopulator pop = new AutoPopulator(f, s, a, d);
                    pop.setup();
                    return pop;
                };
            
            Form main = new mainWindow(populatorFactory(fetcher), systems);

            Application.Run(main);
        }
    }
}
