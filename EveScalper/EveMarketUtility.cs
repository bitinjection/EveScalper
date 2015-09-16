using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveScalper
{
    public class EveMarketUtility
    {
        public static long fetchVolume(int id)
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
    }
}
