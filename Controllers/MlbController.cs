using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myvueasp.Models;
using Newtonsoft.Json;

namespace myvueasp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class MlbController : Controller
    {
        private IEnumerable<Team> _teams = null;

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

        private static async Task<HttpResponseMessage> MakeRequest()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "1ae6fa2ee513451cb5992ff9c91b5a3d");

            var uri = "https://api.fantasydata.net/v3/mlb/scores/JSON/teams?" + queryString;

            return await client.GetAsync(uri);
        }

    }
}