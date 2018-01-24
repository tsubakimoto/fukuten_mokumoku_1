using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace myvueasp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }

        public IActionResult Profile()
        {
            return Ok(new {
                Name = "yuta",
                Age = 30,
                Birthday = DateTime.Parse("1987/08/08")
            });
        }

        [Produces("application/json")]
        public async Task<IActionResult> Team()
        {
            //var response = await MakeRequestAsync();
            dynamic response = @"
[
    {
        'TeamID': 14,
        'Key': 'ARI',
        'Active': true,
        'City': 'Arizona',
        'Name': 'Diamondbacks',
        'StadiumID': 54,
        'League': 'NL',
        'Division': 'West',
        'PrimaryColor': 'A71930',
        'SecondaryColor': 'E3D4AD',
        'TertiaryColor': '000000',
        'QuaternaryColor': '33CCFF',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/8/89/Arizona_Diamondbacks_logo.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/en/c/ce/DbacksCapLogo.png',
        'GlobalTeamID': 10000014
    },
    {
        'TeamID': 26,
        'Key': 'ATL',
        'Active': true,
        'City': 'Atlanta',
        'Name': 'Braves',
        'StadiumID': 68,
        'League': 'NL',
        'Division': 'East',
        'PrimaryColor': '13274F',
        'SecondaryColor': 'CE1141',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/f/f2/Atlanta_Braves.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/7/7a/Atlanta_Braves_Insignia.svg',
        'GlobalTeamID': 10000026
    },
    {
        'TeamID': 19,
        'Key': 'BAL',
        'Active': true,
        'City': 'Baltimore',
        'Name': 'Orioles',
        'StadiumID': 22,
        'League': 'AL',
        'Division': 'East',
        'PrimaryColor': 'DF4601',
        'SecondaryColor': '000000',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/thumb/e/ef/Baltimore_Orioles_logo.svg/200px-Baltimore_Orioles_logo.svg.png',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/en/thumb/7/75/Baltimore_Orioles_cap.svg/105px-Baltimore_Orioles_cap.svg.png',
        'GlobalTeamID': 10000019
    },
    {
        'TeamID': 25,
        'Key': 'BOS',
        'Active': true,
        'City': 'Boston',
        'Name': 'Red Sox',
        'StadiumID': 50,
        'League': 'AL',
        'Division': 'East',
        'PrimaryColor': 'BD3039',
        'SecondaryColor': '0D2B56',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/6/6d/RedSoxPrimary_HangingSocks.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/2/21/Bosb.png',
        'GlobalTeamID': 10000025
    },
    {
        'TeamID': 9,
        'Key': 'CHC',
        'Active': true,
        'City': 'Chicago',
        'Name': 'Cubs',
        'StadiumID': 27,
        'League': 'NL',
        'Division': 'Central',
        'PrimaryColor': '0E3386',
        'SecondaryColor': 'CC3433',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Chicago_Cubs_logo.svg/99px-Chicago_Cubs_logo.svg.png',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/8/89/Chicago_Cubs_Cap_Insignia.svg',
        'GlobalTeamID': 10000009
    },
    {
        'TeamID': 16,
        'Key': 'CHW',
        'Active': true,
        'City': 'Chicago',
        'Name': 'White Sox',
        'StadiumID': 25,
        'League': 'AL',
        'Division': 'Central',
        'PrimaryColor': '000000',
        'SecondaryColor': 'C4CED4',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/commons/c/c1/Chicago_White_Sox.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/d/d6/Chicago_White_Sox_Insignia.svg',
        'GlobalTeamID': 10000016
    },
    {
        'TeamID': 2,
        'Key': 'CIN',
        'Active': true,
        'City': 'Cincinnati',
        'Name': 'Reds',
        'StadiumID': 64,
        'League': 'NL',
        'Division': 'Central',
        'PrimaryColor': 'C6011F',
        'SecondaryColor': '000000',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/commons/0/01/Cincinnati_Reds_Logo.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/7/71/Cincinnati_Reds_Cap_Insignia.svg',
        'GlobalTeamID': 10000002
    },
    {
        'TeamID': 10,
        'Key': 'CLE',
        'Active': true,
        'City': 'Cleveland',
        'Name': 'Indians',
        'StadiumID': 10,
        'League': 'AL',
        'Division': 'Central',
        'PrimaryColor': 'E31937',
        'SecondaryColor': '002B5C',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/commons/e/e5/Indians_Logo_-_2014_Season.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/en/thumb/0/0d/Cleveland_Indians_cap_logo.svg/547px-Cleveland_Indians_cap_logo.svg.png',
        'GlobalTeamID': 10000010
    },
    {
        'TeamID': 23,
        'Key': 'COL',
        'Active': true,
        'City': 'Colorado',
        'Name': 'Rockies',
        'StadiumID': 44,
        'League': 'NL',
        'Division': 'West',
        'PrimaryColor': '33006F',
        'SecondaryColor': '000000',
        'TertiaryColor': 'C4CED4',
        'QuaternaryColor': 'FFFFFF',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Colorado_Rockies_logo.svg/83px-Colorado_Rockies_logo.svg.png',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/thumb/2/2d/Colorado_Rockies_Cap_Insignia.svg/97px-Colorado_Rockies_Cap_Insignia.svg.png',
        'GlobalTeamID': 10000023
    },
    {
        'TeamID': 17,
        'Key': 'DET',
        'Active': true,
        'City': 'Detroit',
        'Name': 'Tigers',
        'StadiumID': 62,
        'League': 'AL',
        'Division': 'Central',
        'PrimaryColor': '0C2C56',
        'SecondaryColor': 'FF6600',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/commons/2/20/Detroit_tigers_textlogo.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/9/94/Detroit_Tigers_Insignia.svg',
        'GlobalTeamID': 10000017
    },
    {
        'TeamID': 30,
        'Key': 'HOU',
        'Active': true,
        'City': 'Houston',
        'Name': 'Astros',
        'StadiumID': 63,
        'League': 'AL',
        'Division': 'West',
        'PrimaryColor': '002D62',
        'SecondaryColor': 'EB6E1F',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/commons/6/6b/Houston-Astros-Logo.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/f/f6/Houston_Astros_cap_logo.svg',
        'GlobalTeamID': 10000030
    },
    {
        'TeamID': 5,
        'Key': 'KC',
        'Active': true,
        'City': 'Kansas City',
        'Name': 'Royals',
        'StadiumID': 33,
        'League': 'AL',
        'Division': 'Central',
        'PrimaryColor': '004687',
        'SecondaryColor': 'C09A5B',
        'TertiaryColor': '000000',
        'QuaternaryColor': '7AB2DD',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/1/1c/Kansas_City_Royals.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/8/88/Kansas_City_Royals_Insignia.svg',
        'GlobalTeamID': 10000005
    },
    {
        'TeamID': 21,
        'Key': 'LAA',
        'Active': true,
        'City': 'Los Angeles',
        'Name': 'Angels',
        'StadiumID': 28,
        'League': 'AL',
        'Division': 'West',
        'PrimaryColor': 'BA0021',
        'SecondaryColor': '003263',
        'TertiaryColor': 'C4CED4',
        'QuaternaryColor': 'FFFFFF',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/commons/8/8b/Los_Angeles_Angels_of_Anaheim.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/7/79/Los_Angeles_Angels_of_Anaheim_Insignia.svg',
        'GlobalTeamID': 10000021
    },
    {
        'TeamID': 1,
        'Key': 'LAD',
        'Active': true,
        'City': 'Los Angeles',
        'Name': 'Dodgers',
        'StadiumID': 31,
        'League': 'NL',
        'Division': 'West',
        'PrimaryColor': '005A9C',
        'SecondaryColor': 'FFFFFF',
        'TertiaryColor': 'EF3E42',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/2/20/Los_Angeles_Dodgers_Logo.png',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/f/f6/LA_Dodgers.svg',
        'GlobalTeamID': 10000001
    },
    {
        'TeamID': 22,
        'Key': 'MIA',
        'Active': true,
        'City': 'Miami',
        'Name': 'Marlins',
        'StadiumID': 57,
        'League': 'NL',
        'Division': 'East',
        'PrimaryColor': '000000',
        'SecondaryColor': 'FF6600',
        'TertiaryColor': '0077C8',
        'QuaternaryColor': 'FFD100',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/thumb/f/f0/Miami_Marlins_logo.svg/99px-Miami_Marlins_logo.svg.png',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/en/4/47/MiamiMarlinscap.PNG',
        'GlobalTeamID': 10000022
    },
    {
        'TeamID': 32,
        'Key': 'MIL',
        'Active': true,
        'City': 'Milwaukee',
        'Name': 'Brewers',
        'StadiumID': 19,
        'League': 'NL',
        'Division': 'Central',
        'PrimaryColor': '0A2351',
        'SecondaryColor': 'B6922E',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/1/11/Milwaukee_Brewers_Logo.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/en/4/4a/MilwaukeeBrewers_caplogo.svg',
        'GlobalTeamID': 10000032
    },
    {
        'TeamID': 20,
        'Key': 'MIN',
        'Active': true,
        'City': 'Minnesota',
        'Name': 'Twins',
        'StadiumID': 14,
        'League': 'AL',
        'Division': 'Central',
        'PrimaryColor': '002B5C',
        'SecondaryColor': 'D31145',
        'TertiaryColor': 'CFAB7A',
        'QuaternaryColor': 'FFFFFF',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/commons/6/61/MinnesotaTwins.PNG',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/en/2/2f/Minnesota_Twins_Insignia.svg',
        'GlobalTeamID': 10000020
    },
    {
        'TeamID': 18,
        'Key': 'NYM',
        'Active': true,
        'City': 'New York',
        'Name': 'Mets',
        'StadiumID': 8,
        'League': 'NL',
        'Division': 'East',
        'PrimaryColor': '002D72',
        'SecondaryColor': 'FF5910',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/7/7b/New_York_Mets.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/en/7/7b/New_York_Mets.svg',
        'GlobalTeamID': 10000018
    },
    {
        'TeamID': 29,
        'Key': 'NYY',
        'Active': true,
        'City': 'New York',
        'Name': 'Yankees',
        'StadiumID': 35,
        'League': 'AL',
        'Division': 'East',
        'PrimaryColor': '132448',
        'SecondaryColor': 'C4CED4',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/2/25/NewYorkYankees_PrimaryLogo.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/7/70/NewYorkYankees_caplogo.svg',
        'GlobalTeamID': 10000029
    },
    {
        'TeamID': 24,
        'Key': 'OAK',
        'Active': true,
        'City': 'Oakland',
        'Name': 'Athletics',
        'StadiumID': 23,
        'League': 'AL',
        'Division': 'West',
        'PrimaryColor': '003831',
        'SecondaryColor': 'EFB21E',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/commons/thumb/a/a4/Oakland_A%27s_logo.svg/150px-Oakland_A%27s_logo.svg.png',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/3/3a/Oakland_Athletics_cap_logo.png',
        'GlobalTeamID': 10000024
    },
    {
        'TeamID': 12,
        'Key': 'PHI',
        'Active': true,
        'City': 'Philadelphia',
        'Name': 'Phillies',
        'StadiumID': 51,
        'League': 'NL',
        'Division': 'East',
        'PrimaryColor': 'E81828',
        'SecondaryColor': '284898',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/8/84/Philadelphia_Phillies.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/thumb/a/a3/Philadelphia_Phillies_Insignia.svg/100px-Philadelphia_Phillies_Insignia.svg.png',
        'GlobalTeamID': 10000012
    },
    {
        'TeamID': 4,
        'Key': 'PIT',
        'Active': true,
        'City': 'Pittsburgh',
        'Name': 'Pirates',
        'StadiumID': 29,
        'League': 'NL',
        'Division': 'Central',
        'PrimaryColor': '000000',
        'SecondaryColor': 'FDB827',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/commons/8/81/Pittsburgh_Pirates_logo_2014.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/2/24/Pittsburgh_Pirates_Cap_Insignia.svg',
        'GlobalTeamID': 10000004
    },
    {
        'TeamID': 33,
        'Key': 'SD',
        'Active': true,
        'City': 'San Diego',
        'Name': 'Padres',
        'StadiumID': 1,
        'League': 'NL',
        'Division': 'West',
        'PrimaryColor': '05143F',
        'SecondaryColor': 'FFFFFF',
        'TertiaryColor': '',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/commons/thumb/a/a4/SDPadres_logo.svg/75px-SDPadres_logo.svg.png',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/San_Diego_Padres_logotype.svg/100px-San_Diego_Padres_logotype.svg.png',
        'GlobalTeamID': 10000033
    },
    {
        'TeamID': 13,
        'Key': 'SEA',
        'Active': true,
        'City': 'Seattle',
        'Name': 'Mariners',
        'StadiumID': 65,
        'League': 'AL',
        'Division': 'West',
        'PrimaryColor': '0C2C56',
        'SecondaryColor': 'C4CED4',
        'TertiaryColor': '005C5C',
        'QuaternaryColor': 'FFFFFF',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/b/b0/Seattle_Mariners_logo.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/en/8/8a/Seattle_Mariners_Insignia.svg',
        'GlobalTeamID': 10000013
    },
    {
        'TeamID': 15,
        'Key': 'SF',
        'Active': true,
        'City': 'San Francisco',
        'Name': 'Giants',
        'StadiumID': 13,
        'League': 'NL',
        'Division': 'West',
        'PrimaryColor': 'FD5A1E',
        'SecondaryColor': '000000',
        'TertiaryColor': '8B6F4E',
        'QuaternaryColor': 'E6D8AF',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/5/58/San_Francisco_Giants_Logo.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/San_Francisco_Giants_Cap_Insignia.svg/97px-San_Francisco_Giants_Cap_Insignia.svg.png',
        'GlobalTeamID': 10000015
    },
    {
        'TeamID': 31,
        'Key': 'STL',
        'Active': true,
        'City': 'St. Louis',
        'Name': 'Cardinals',
        'StadiumID': 41,
        'League': 'NL',
        'Division': 'Central',
        'PrimaryColor': 'C41E3A',
        'SecondaryColor': '000066',
        'TertiaryColor': 'FEDB00',
        'QuaternaryColor': 'FFFFFF',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/thumb/9/9d/St._Louis_Cardinals_logo.svg/105px-St._Louis_Cardinals_logo.svg.png',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/e/ee/St_Louis_Cardinals_Cap_Insignia.svg',
        'GlobalTeamID': 10000031
    },
    {
        'TeamID': 11,
        'Key': 'TB',
        'Active': true,
        'City': 'Tampa Bay',
        'Name': 'Rays',
        'StadiumID': 18,
        'League': 'AL',
        'Division': 'East',
        'PrimaryColor': '092C5C',
        'SecondaryColor': '8FBCE6',
        'TertiaryColor': 'F5D130',
        'QuaternaryColor': 'FFFFFF',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/c/c6/Tampa_Bay_Rays.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/e/e2/ALE-TB-Insignia.png',
        'GlobalTeamID': 10000011
    },
    {
        'TeamID': 28,
        'Key': 'TEX',
        'Active': true,
        'City': 'Texas',
        'Name': 'Rangers',
        'StadiumID': 21,
        'League': 'AL',
        'Division': 'West',
        'PrimaryColor': '003278',
        'SecondaryColor': 'C0111F',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/4/41/Texas_Rangers.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/e/e2/Texas_Rangers_Insignia.svg',
        'GlobalTeamID': 10000028
    },
    {
        'TeamID': 3,
        'Key': 'TOR',
        'Active': true,
        'City': 'Toronto',
        'Name': 'Blue Jays',
        'StadiumID': 42,
        'League': 'AL',
        'Division': 'East',
        'PrimaryColor': '134A8E',
        'SecondaryColor': '1D2D5C',
        'TertiaryColor': 'E8291C',
        'QuaternaryColor': 'FFFFFF',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/b/ba/Toronto_Blue_Jays_logo.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/en/1/11/TorontoBlueJays2012cap.png',
        'GlobalTeamID': 10000003
    },
    {
        'TeamID': 35,
        'Key': 'WSH',
        'Active': true,
        'City': 'Washington',
        'Name': 'Nationals',
        'StadiumID': 53,
        'League': 'NL',
        'Division': 'East',
        'PrimaryColor': 'AB0003',
        'SecondaryColor': '11225B',
        'TertiaryColor': 'FFFFFF',
        'QuaternaryColor': '',
        'WikipediaLogoUrl': 'https://upload.wikimedia.org/wikipedia/en/a/a3/Washington_Nationals_logo.svg',
        'WikipediaWordMarkUrl': 'https://upload.wikimedia.org/wikipedia/commons/e/e5/Washington_Nationals_Cap_Insig.svg',
        'GlobalTeamID': 10000035
    }
]";
            return Ok(response);
        }

        private static async Task<HttpResponseMessage> MakeRequestAsync()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "d527840c767a488b9451d424a7e75b03");

            var uri = "https://api.fantasydata.net/v3/mlb/scores/JSON/teams?" + queryString;

            var response = await client.GetAsync(uri);
            return response;
        }
    }
}
