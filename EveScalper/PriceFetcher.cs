using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;

namespace EveScalper
{
    public class PriceFetcher
    {
        private readonly RandomWalker walker;

        public PriceFetcher(RandomWalker walker)
        {
            this.walker = walker;
        }

        private static Security fetchPrices(EveCentralParameters parameters)
        {
            XDocument xml = EveCentralParameters.downloadPrices(parameters);

            string name = xml.Descendants("itemname").First().Value;

            Func<string, IEnumerable<double>> process =
                (string type) => xml.Descendants(type)
                .Descendants("order")
                .Elements("price")
                .Select(p => double.Parse(p.Value))
                .DefaultIfEmpty(0);

            double buy = process("buy_orders").Max();
            double sell = process("sell_orders").Min();

            int id = parameters.Id;

            long volume = fetchVolume(id);

            return new Security(id, name, buy, sell, volume);
        }

        private static long fetchVolume(int id)
        {
            String emdUrl = "http://api.eve-marketdata.com/api/item_history2.xml?char_name=demo&region_ids=10000002&type_ids=" + id;
            using (WebClient client = new WebClient())
            {
                string emdData = client.DownloadString(emdUrl);

                XDocument emd = XDocument.Parse(emdData);

                XElement volumeRow = emd.Descendants("rowset")
                .DefaultIfEmpty()
                .Descendants("row")
                .LastOrDefault();

                long volume = (volumeRow == null) ? 0 :
                    Convert.ToInt64(volumeRow.Attribute("volume").Value);

                return volume;
            }
        }


        public Security grabRandomItem(int station, int age)
        {
            int id = this.walker.pick();

            return grabItem(id, station, age);
        }

        public Security grabItem(int id, int station, int age)
        {
            try
            {
                EveCentralParameters parameters =
                    new EveCentralParameters(id, age, station);
                Security security = fetchPrices(parameters);
                return security;
            }
            catch (WebException exception)
            {
                MessageBox.Show(exception.Message);
                return null; // Not planning to recover from this
            }
        }
    }
}
