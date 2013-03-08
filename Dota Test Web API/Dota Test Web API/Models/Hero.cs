using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dota_Test_Web_API.Models
{
    public class Hero
    {
        public string name { get; set; }
        public int id { get; set; }
        public string localized_name { get; set; }
    }
}