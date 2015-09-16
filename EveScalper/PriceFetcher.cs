using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Xml.Linq;

namespace EveScalper
{
    using PriceDownloader = Func<EveCentralUtility, XDocument>;
    using VolumeDownloader = Func<int, long>;

    public class PriceFetcher : IPriceFetcher
    {

        private readonly IPriceWalker walker;
        private readonly PriceDownloader downloadPrices;
        private readonly VolumeDownloader downloadVolume;

        public PriceFetcher(IPriceWalker walker,
            PriceDownloader downloadPrices,
            VolumeDownloader downloadVolume)
        {
            this.walker = walker;
            this.downloadPrices = downloadPrices;
            this.downloadVolume = downloadVolume;
        }

        public static Security fetchPrices(EveCentralUtility parameters,
            PriceDownloader downloadPrices,
            VolumeDownloader downloadVolume)
        {
            XDocument xml = downloadPrices(parameters);

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

            long volume = downloadVolume(id);

            return new Security(id, name, buy, sell, volume);
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
                EveCentralUtility parameters =
                    new EveCentralUtility(id, age, station);
                Security security = fetchPrices(parameters,
                    this.downloadPrices,
                    this.downloadVolume);
                return security;
            }
            catch (WebException exception)
            {
                // TODO: Recover from this
                MessageBox.Show(exception.Message);
                return null; 
            }
        }
    }
}
