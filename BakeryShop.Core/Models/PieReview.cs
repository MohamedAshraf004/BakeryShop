using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop.Core.Models
{
    public class PieReview
    {

        public int PieReviewId { get; set; }
        public Pie Pie { get; set; }
        public string Review { get; set; }
    }
}
