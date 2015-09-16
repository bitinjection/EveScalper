using Microsoft.VisualStudio.TestTools.UnitTesting;
using EveScalper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveScalper.Tests
{
    [TestClass()]
    public class PriceFetcherTests
    {
        private static IPriceFetcher fetcher;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext c)
        {

            IList<int> ids = new List<int>();
            ids.Add(1);
            ids.Add(2);
            ids.Add(3);


            IPriceWalker walker = new RandomWalker(ids);

            fetcher = new PriceFetcher(walker,
                MockPriceFetcherUtilityMethods.downloadPrices,
                MockPriceFetcherUtilityMethods.fetchVolume);
        }

        [TestMethod()]
        public void grabRandomItemTest()
        {
            Security security = fetcher.grabRandomItem(0, 0);
            Assert.AreEqual(security.Name,
                "True Sansha Heavy Energy Neutralizer");
        }

        [TestMethod()]
        public void grabItemTest()
        {
            Security security = fetcher.grabItem(0, 0, 0);
            Assert.AreEqual(security.Name,
                "True Sansha Heavy Energy Neutralizer");
        }

        [TestMethod()]
        public void fetchSellPriceTest()
        {
            Security security = fetcher.grabRandomItem(0, 0);
            Assert.AreEqual(110000000, security.Sell);
        }

        [TestMethod()]
        public void fetchBuyPriceTest()
        {
            Security security = fetcher.grabRandomItem(0, 0);
            Assert.AreEqual(97900900.1, security.Buy);
        }

        [TestMethod()]
        public void fetchVolumeTest()
        {
            Security security = fetcher.grabRandomItem(0, 0);
            Assert.AreEqual(777, security.Volume);
        }
    }
}