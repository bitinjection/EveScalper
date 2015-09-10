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

            IStaticDataExport database =
                new StaticDataExport("sqlite-latest.sqlite");

            IReadOnlyList<int> ids = database.inventoryIds();
            IReadOnlyList<SystemPair> systems = database.systemList();

            RandomWalker walker = new RandomWalker(new List<int>(ids));

            PriceFetcher fetcher = new PriceFetcher(walker);

            AutoPopulator populator = new AutoPopulator(fetcher,
                30000142,
                5,
                30000);
            populator.setup();

            Form main = new mainWindow(populator, systems);

            Application.Run(main);
        }
    }
}
