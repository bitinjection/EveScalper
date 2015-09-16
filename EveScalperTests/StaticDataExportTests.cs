using Microsoft.VisualStudio.TestTools.UnitTesting;
using EveScalper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveScalper.Tests
{
    using SystemPair = Tuple<string,int>;

    [TestClass()]
    public class StaticDataExportTests
    {
        public static StaticDataExport database;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext c)
        {
            database = new StaticDataExport("sqlite-latest.sqlite");
        }

        [TestMethod()]
        public void systemListTest()
        {
            IReadOnlyList<SystemPair> stationSystems = database.systemList();
            int total = stationSystems.Count;

            Assert.AreEqual(1777, stationSystems.Count);
        }

        [TestMethod()]
        public void inventoryIdsTest()
        {
            IReadOnlyList<int> ids = database.inventoryIds();

            Assert.AreEqual(14973, ids.Count);
        }
    }
}