using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Dota_Test_Web_API.Models
{
	public class MatchDetails
	{
		public MatchDetailsResult result = new MatchDetailsResult();

		/// <summary>
		/// Populates the match details based on the matchId given
		/// </summary>
		/// <param name="matchId">The ID of the match</param>
		public void populateResult(int matchId)
		{
			DotaAPI apiCaller = new DotaAPI();
			string matchJson = string.Empty;
			MatchDetails temp = new MatchDetails();
			HeroDictionary heroDictionary = HeroDictionary.Instance;

			matchJson = apiCaller.callApi("match_id=" + matchId); //hardcoded match_id = 127835521
			temp = JsonConvert.DeserializeObject<MatchDetails>(matchJson);

			//Populate the player and hero names as well as localized hero name
			foreach (Player player in temp.result.players)
			{
				player.account_name = player.getPlayerName();
				player.hero_name = heroDictionary.heroes[player.hero_id].localized_name;
				player.internal_hero_name = heroDictionary.heroes[player.hero_id].name.Substring(14);
				//player.populateItems();
			}

			this.result = temp.result;
		}

		private List<string> getPlayerNames()
		{
			string playerName = string.Empty;
			List<string> playerNames = new List<string>();
			SteamPlayerSummaries player = new SteamPlayerSummaries();

			foreach (Player thePlayer in this.result.players)
			{
				playerNames.Add(thePlayer.getPlayerName());
			}

			return playerNames;
		}
	}
}