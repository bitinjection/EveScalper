using System.Xml.Linq;
using System;
using System.Net;
using System.Linq;

namespace EveScalper
{
    public class EveCentralParameters
    {
        public readonly int Id;
        public readonly int Hours;
        public readonly int System;

        public EveCentralParameters(int id, int hours, int system)
        {
            this.Id = id;
            this.Hours = hours;
            this.System = system;
        }

        public static XDocument downloadPrices(EveCentralParameters parameters)
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

    }
}
