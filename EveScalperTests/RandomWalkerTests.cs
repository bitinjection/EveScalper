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
    public class RandomWalkerTests
    {
        private RandomWalker walker;

        [TestInitialize()]
        public void TestInitialize()
        {
            List<int> testList = new List<int>();
            testList.Add(3);
            testList.Add(5);
            testList.Add(9);

            this.walker = new RandomWalker(testList);
        }

        [TestMethod()]
        public void testRemainingIds()
        {
            Assert.AreEqual(3, this.walker.remainingIds());
        }

        [TestMethod()]
        public void pickTestReducesList()
        {
            this.walker.pick();
            Assert.AreEqual(2, this.walker.remainingIds());
        }

        [TestMethod()]
        public void pickTestResetsWhenEmpty()
        {
            this.walker.pick();
            this.walker.pick();
            this.walker.pick();

            Assert.AreEqual(3, this.walker.remainingIds());
        }

        [TestMethod()]
        public void resetTest()
        {
            this.walker.pick();
            this.walker.reset();

            Assert.AreEqual(3, this.walker.remainingIds());
        }
    }
}