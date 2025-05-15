using System;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace moneyLaundring
{
    public class HttpClientFile
    {
        private readonly HttpClient _client;

        public HttpClientFile(IHttpClientFactory factory)
        {
            _client = factory.CreateClient();
        }

        public async Task<decimal?> GetEuroRateAsync()
        {
            var url = "http://api.napiarfolyam.hu?bank=mnb&valuta=eur&valutanem=deviza";

            var response = await _client.GetAsync(url);
            if (!response.IsSuccessStatusCode)
                return null;

            var xml = await response.Content.ReadAsStringAsync();
            var doc = XDocument.Parse(xml);

            var rate = doc.Descendants("deviza")
                .Elements("item")
                .FirstOrDefault(e => e.Element("penznem")?.Value == "EUR")
                ?.Element("kozep")?.Value;

            if (rate != null && decimal.TryParse(rate.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
            {
                return result;
            }

            return null;
        }
    }
}
