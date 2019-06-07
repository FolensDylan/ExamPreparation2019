using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowestHealthFood_FolensDylan.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Img { get; set; }
        public String Cook { get; set; }
        public int? Calories { get; set; }
        public int? Price { get; set; }
    }
}
