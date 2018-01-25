using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using myvueasp.Models;
using Newtonsoft.Json;

namespace myvueasp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class MlbController : Controller
    {
        private readonly AppSettings _appSettings;
        private IEnumerable<Team> _teams = null;

        public MlbController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Team()
        {
            if (_teams == null || !_teams.Any())
            {
                var response = await MakeRequest();
                var content = await response.Content.ReadAsStringAsync();
                _teams = JsonConvert.DeserializeObject<IEnumerable<Team>>(content);
            }
            return Ok(_teams);
        }

        private async Task<HttpResponseMessage> MakeRequest()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _appSettings.FantasyDataSubscriptionKey);

            var uri = "https://api.fantasydata.net/v3/mlb/scores/JSON/teams?" + queryString;

            return await client.GetAsync(uri);
        }

    }
}