using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop.Core.Models
{
    public class Chef
    {
        public int ChefId { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public DateTime Birthdate { get; set; }
        public int SSN { get; set; }
        public List<Pie> Pies { get; set; }
        public Team Team { get; set; }
    }
}
