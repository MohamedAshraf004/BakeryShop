using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop.Core.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Description { get; set; }
        public List<Chef> Chefs { get; set; }
    }
}
