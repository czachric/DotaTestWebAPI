using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dota_Test_Web_API.Models
{
    public class HeroResult
    {
        public List<Hero> heroes { get; set; }
        public int count { get; set; }
    }
}