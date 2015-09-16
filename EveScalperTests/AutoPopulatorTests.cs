using Microsoft.VisualStudio.TestTools.UnitTesting;
using EveScalper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveScalper.Tests
{
    [TestClass()]
    public class AutoPopulatorTests
    {
        private static IPopulator populator;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext c)
        {
            const int delay = 5;
            const int dummy = 0;

            MockSimplePriceFetcher fetcher = new MockSimplePriceFetcher();

            populator = new AutoPopulator(fetcher, dummy, dummy, delay);
            populator.setup();
        }

        [TestMethod()]
        public void startTest()
        {
            populator.start();

            Assert.IsTrue(populator.Running);
        }

        [TestMethod()]
        public void fetchTest()
        {
            populator.fetch(null, null);

            Assert.AreEqual("Test Item 1", populator.MostRecent.Name);
        }

        [TestMethod()]
        public void stopTest()
        {
            populator.start();
            populator.stop();

            Assert.IsFalse(populator.Running);
        }
    }
}