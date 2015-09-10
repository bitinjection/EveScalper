using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;

namespace EveScalper
{
    public partial class mainWindow : Form
    {
        private readonly AutoPopulator populator;
        private bool populating;

        public mainWindow(AutoPopulator populator)
        {
            InitializeComponent();

            this.populator = populator;
            this.populating = false;
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
            int station = 30000142;
            int age = 5;

            if (false == this.populating)
            {
                this.populating = true;
                this.populator.start();
                this.populator.OnSecurityUpdate += addSecurity;
            }
            else
            {
                this.populating = false;
                this.populator.stop();
                this.populator.OnSecurityUpdate -= addSecurity;
            }
        }

        private void addSecurity(object o, SecurityArgs securityArguments)
        {
            render(securityArguments.security);
        }

    }

}
