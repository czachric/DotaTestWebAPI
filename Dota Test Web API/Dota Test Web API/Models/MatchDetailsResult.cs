using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dota_Test_Web_API.Models
{
	public class MatchDetailsResult
	{
		public List<Player> players { get; set; }
		public int duration { get; set; }
		public string first_blood_time { get; set; }
	}
}