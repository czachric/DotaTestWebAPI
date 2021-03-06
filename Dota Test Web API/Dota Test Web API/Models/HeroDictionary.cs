﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace Dota_Test_Web_API.Models
{
	public sealed class HeroDictionary
	{
		public List<Hero> heroes { get; set; }

		private static readonly HeroDictionary instance = new HeroDictionary();

		// Explicit static constructor to tell C# compiler
		// not to mark type as beforefieldinit
		static HeroDictionary()
		{
		}

		public static HeroDictionary Instance
		{
			get
			{
				return instance;
			}
		}

		//Singleton Initialization
		private HeroDictionary()
		{
			populateHeroDefinitions();
		}

		private void populateHeroDefinitions()
		{
			Heroes temp = new Heroes();
			string heroJson = new DotaAPI().callHeroApi();
			
			temp = JsonConvert.DeserializeObject<Heroes>(heroJson); //only necessary because of valve api formatting

			heroes = temp.result.heroes;

			
			Hero placeHolder = new Hero(); //valve y u no zero base your heroes?!
			placeHolder.id = 0;
			placeHolder.localized_name = "not_a_hero";
			placeHolder.name = "Not A Hero";
			heroes.Insert(0, placeHolder);
			heroes.Insert(24, placeHolder); //no hero with id 24. wat.
		}
	}
}