using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using EveScalper;

namespace EveScalper
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void render(Security security)
        {
            Func<double, string> toCurrency =
                (number) => String.Format("{0:n2}", number);

            Func<string, string> toEnglish =
                (value) =>
                {
                    // TODO: Make this more robust
                    if (value == "0.00")
                        return "None";
                    else if (value == "NaN")
                        return "N/A";
                    else
                        return value;
                };

            Func<double, string> process =
                (number) => toEnglish(toCurrency(number));

            string sell = process(security.Sell);
            string buy = process(security.Buy);
            string spread = process(security.Spread);
            string percentage = process(security.Percentage);
            string capitalization = process(security.Capitalization);
            string volume = String.Format("{0:n}", security.Volume);

            string[] row = {
                         security.Name,
                         sell,
                         buy,
                         volume,
                         spread,
                         percentage,
                         capitalization
                       };

            ListViewItem item = new ListViewItem(row);
            this.securitiesListView.Items.Add(item);
        }

        private void populate_Click(object send, EventArgs e)
        {
            string path = "sqlite-latest.sqlite";
            using (StaticDataExport data = new StaticDataExport(path))
            {
                IReadOnlyList<int> ids = data.inventoryIds();
                try
                {
                    Random generator = new Random(
                        (int)DateTime.Now.Ticks & 0x0000FFFF);
                    int item = ids[generator.Next() % ids.Count];
                    int station = 30000142;
                    int age = 5;
                    EveCentralParameters parameters =
                        new EveCentralParameters(item, age, station);
                    Security security = fetchPrices(parameters);
                    render(security);
                }
                catch (WebException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private static XDocument downloadPrices(EveCentralParameters parameters)
        {
            UriBuilder url = new UriBuilder();
            url.Scheme = "http";
            url.Host = "api.eve-central.com";
            url.Path = "api/quicklook";
            url.Query = "typeid=" + parameters.Id +
                "&usesystem=" + parameters.System +
                "&sethour=" + parameters.Hours;


            using (WebClient client = new WebClient())
                return XDocument.Parse(client.DownloadString(url.ToString()));
        }

        private static Security fetchPrices(EveCentralParameters parameters)
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

            //EveMarketParameters parameters2 = new EveMarketParameters()
            int id = parameters.Id;
            String emdUrl = "http://api.eve-marketdata.com/api/item_history2.xml?char_name=demo&region_ids=10000002&type_ids=" + id;
            string emdData;
            using (WebClient client = new WebClient())
                emdData = client.DownloadString(emdUrl);

            XDocument emd = XDocument.Parse(emdData);

            MessageBox.Show("Trying element " + id);
                XElement volumeRow = emd.Descendants("rowset")
                .DefaultIfEmpty()
                .Descendants("row")
                .LastOrDefault();

            long volume = (volumeRow == null) ?  0 :
                Convert.ToInt64(volumeRow.Attribute("volume").Value);

            return new Security(name, buy, sell, volume);
        }
    }

}
