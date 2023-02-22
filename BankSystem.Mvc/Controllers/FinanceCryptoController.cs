using BankSystem.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BankSystem.Mvc.Controllers
{
    public class FinanceCryptoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<CryptoViewModel> CryptoViewModels = new List<CryptoViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://coinranking1.p.rapidapi.com/coins?referenceCurrencyUuid=yhjMzLPhuIDl&timePeriod=24h&tiers%5B0%5D=1&orderBy=marketCap&orderDirection=desc&limit=50&offset=0"),
                Headers =
                {
                    { "X-RapidAPI-Key", "cf28c5131dmshe93bf04a0d94549p1d27f6jsna8a8ad07d3cd" },
                    { "X-RapidAPI-Host", "coinranking1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<CryptoViewModel>(body);
                return View(values.data.coins);
            }
        }
    }
}
