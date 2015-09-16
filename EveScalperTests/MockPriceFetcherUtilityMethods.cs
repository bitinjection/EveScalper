using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Xml.Linq;

namespace EveScalper.Tests
{
    class MockPriceFetcherUtilityMethods
    {
        public static XDocument downloadPrices(EveCentralUtility parameters)
        {
            String xml = File.ReadAllText("neutxml.txt");
            return XDocument.Parse(xml);
        }

        public static long fetchVolume(int id)
        {
            return 777;
        }
    }
}
