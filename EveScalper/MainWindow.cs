using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
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

        public static IReadOnlyList<int> doSQLStuff(SQLiteConnection connection)
        {
            const string sql = "SELECT typeID FROM invTypes";
            SQLiteCommand command = new SQLiteCommand(sql, connection);

            SQLiteDataReader result = command.ExecuteReader();

            List<int> typeIds = new List<int>();

            while (result.Read())
            {
                int current = result.GetInt32(0);
                typeIds.Add(current);
            }
            return typeIds.AsReadOnly();
        }

        private void populate_Click(object send, EventArgs e)
        {
            string path = "sqlite-latest.sqlite";
            using (StaticDataExport data = new StaticDataExport(path))
            {
                IReadOnlyList<int> ids = doSQLStuff(data.Connection);
                try
                {
                    EveCentralParameters parameters =
                        new EveCentralParameters(34253, 5, 10000054);
                    Security security = fetchPrices(parameters);

                    Func<double, string> toCurrency =
                        (number) => String.Format("{0:n2}", number);

                    Func<string, string> toEnglish =
                        (value) => {
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
                catch(WebException exception)
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
            String emdUrl = "http://api.eve-marketdata.com/api/item_history2.xml?char_name=demo&region_ids=10000002&type_ids=34";// + id;
            string emdData;
            using (WebClient client = new WebClient())
                emdData = client.DownloadString(emdUrl);

             XDocument emd = XDocument.Parse(emdData);

            long volume = Convert.ToInt64(
                emd.Descendants("rowset")
                .Descendants("row")
                .Last()
                .Attribute("volume")
                .Value);

            return new Security(name, buy, sell, volume);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] testRow = { "one", "two", "three", "four", "five", "six", "seven" };
            ListViewItem item = new ListViewItem(testRow);
            this.securitiesListView.Items.Add(item);
        }
    }

}
