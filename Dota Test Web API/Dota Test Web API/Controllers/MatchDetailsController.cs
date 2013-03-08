using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dota_Test_Web_API.Models;

namespace Dota_Test_Web_API.Controllers
{
    public class MatchDetailsController : ApiController
    {

		public MatchDetails GetMatchDetails(int matchId)
		{
			MatchDetails theMatch = new MatchDetails();

			theMatch.populateResult(matchId);

			return theMatch;
		}

    }
}
