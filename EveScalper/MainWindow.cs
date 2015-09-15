using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;

namespace EveScalper
{
    using PopulatorFactory = Func<int, int, int, IPopulator>;
    public partial class mainWindow : Form
    {
        private readonly PopulatorFactory populatorFactory;
        private IPopulator populator;
        private IReadOnlyList<Tuple<string, int>> systems;
        private bool populating;


        public mainWindow(PopulatorFactory populatorFactory,
            IReadOnlyList<Tuple<string, int>> systems)
        {
            InitializeComponent();

            this.populatorFactory = populatorFactory;
            this.systems = systems;
            this.populating = false;

            foreach (Tuple<string, int> system in systems)
            {
                this.systemList.Items.Add(system.Item1);
            }
            this.systemList.SelectedIndex = 0;
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
            if (false == this.populating)
            {
                this.beginPopulating();
            }
            else
            {
                this.stopPopulating();
            }
        }

        private void beginPopulating()
        {
            this.populator = this.populatorFactory(30000142,
                5,      // Defaulting to 5 hours for now
                30000); // Defaulting to 30 seconds because 3rd party APIs
                        // Don't know how to set limits...

            this.populating = true;
            this.populator.start();
            this.populator.OnSecurityUpdate += addSecurity;
            this.statusLabel.Text =
                "Populating securities...";
            this.runButton.Text = "Stop Populating";
        }

        private void stopPopulating()
        {
            this.populating = false;
            this.populator.stop();
            this.populator.OnSecurityUpdate -= addSecurity;
            this.statusLabel.Text =
                "\"Begin Populating\" to populate securities";
            this.runButton.Text = "Begin Populating";
        }

        private void addSecurity(object o, SecurityArgs securityArguments)
        {
            render(securityArguments.security);
        }
    }

}
