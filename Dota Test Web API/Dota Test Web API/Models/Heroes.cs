﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Dota_Test_Web_API.Models
{
	public class Heroes
	{
		public HeroResult result { get; set; }

		public string getHeroName(int id)
		{
			return heroDictionary[id];
		}

		//Primary property. Implemented at bottom of code due to length
		public Dictionary<int, string> heroDictionary = new Dictionary<int, string>()
		{
			{1, "Anti-Mage"},
			{2, "Axe"},
			{3, "Bane"},
			{4, "Bloodseeker"},
			{5, "Crystal Maiden"},
			{6, "Drow Ranger"},
			{7, "Earthshaker"},
			{8, "Juggernaut"},
			{9, "Mirana"},
			{11, "Shadow Fiend"},
			{10, "Morphling"},
			{12, "Phantom Lancer"},
			{13, "Puck"},
			{14, "Pudge"},
			{15, "Razor"},
			{16, "Sand King"},
			{17, "Storm Spirit"},
			{18, "Sven"},
			{19, "Tiny"},
			{20, "Vengeful Spirit"},
			{21, "Windrunner"},
			{22, "Zeus"},
			{23, "Kunkka"},
			{25, "Lina"},
			{31, "Lich"},
			{26, "Lion"},
			{27, "Shadow Shaman"},
			{28, "Slardar"},
			{29, "Tidehunter"},
			{30, "Witch Doctor"},
			{32, "Riki"},
			{33, "Enigma"},
			{34, "Tinker"},
			{35, "Sniper"},
			{36, "Necrolyte"},
			{37, "Warlock"},
			{38, "Beastmaster"},
			{39, "Queen of Pain"},
			{40, "Venomancer"},
			{41, "Faceless Void"},
			{42, "Skeleton King"},
			{43, "Death Prophet"},
			{44, "Phantom Assassin"},
			{45, "Pugna"},
			{46, "Templar Assassin"},
			{47, "Viper"},
			{48, "Luna"},
			{49, "Dragon Knight"},
			{50, "Dazzle"},
			{51, "Clockwerk"},
			{52, "Leshrac"},
			{53, "Nature's Prophet"},
			{54, "Lifestealer"},
			{55, "Dark Seer"},
			{56, "Clinkz"},
			{57, "Omniknight"},
			{58, "Enchantress"},
			{59, "Huskar"},
			{60, "Night Stalker"},
			{61, "Broodmother"},
			{62, "Bounty Hunter"},
			{63, "Weaver"},
			{64, "Jakiro"},
			{65, "Batrider"},
			{66, "Chen"},
			{67, "Spectre"},
			{69, "Doom"},
			{68, "Ancient Apparition"},
			{70, "Ursa"},
			{71, "Spirit Breaker"},
			{72, "Gyrocopter"},
			{73, "Alchemist"},
			{74, "Invoker"},
			{75, "Silencer"},
			{76, "Outworld Devourer"},
			{77, "Lycanthrope"},
			{78, "Brewmaster"},
			{79, "Shadow Demon"},
			{80, "Lone Druid"},
			{81, "Chaos Knight"},
			{82, "Meepo"},
			{83, "Treant Protector"},
			{84, "Ogre Magi"},
			{85, "Undying"},
			{86, "Rubick"},
			{87, "Disruptor"},
			{88, "Nyx Assassin"},
			{89, "Naga Siren"},
			{90, "Keeper of the Light"},
			{91, "Wisp"},
			{92, "Visage"},
			{93, "Slark"},
			{94, "Medusa"},
			{95, "Troll Warlord"},
			{96, "Centaur Warrunner"},
			{97, "Magnus"},
			{98, "Timbersaw"},
			{99, "Bristlebog"},
			{100, "Tusk"},
			{101, "Skywrath Mage"},
			{102, "Abaddon"}
		};

		/*
		public void populateDictionary()
		{
			DotaAPI caller = new DotaAPI();
			Heroes temp = new Heroes();
			string heroJson = string.Empty;
			idNameDictionary = new Dictionary<int, string>();

			heroJson = caller.callHeroApi();

			temp = JsonConvert.DeserializeObject<Heroes>(heroJson);
			result = temp.result;

			foreach(Hero hero in this.result.heroes)
			{
				idNameDictionary.Add(hero.id, hero.localized_name);
			}

			string dictionaryString = gimmeDatString();
		}

		public string gimmeDatString()
		{
			System.Text.StringBuilder dictionaryString = new System.Text.StringBuilder();
			foreach(KeyValuePair<int,string> pair in idNameDictionary)
			{
				dictionaryString.AppendLine("{" + pair.Key + ", \"" +pair.Value + "\"},");
			}

			return dictionaryString.ToString();
		}
		*/
	}
}