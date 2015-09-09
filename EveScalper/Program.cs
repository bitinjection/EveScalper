using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EveScalper
{
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

            RandomWalker walker = new RandomWalker(new List<int>(ids));

            PriceFetcher fetcher = new PriceFetcher(walker);

            Form main = new mainWindow(fetcher);

            Application.Run(main);
        }
    }
}
