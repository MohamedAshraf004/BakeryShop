using BakeryShop.Core.Models;
using System.Collections.Generic;

namespace BakeryShop.Data.Services
{
    public interface IPieReviewRepository
    {
        void AddPieReview(PieReview pieReview);
        IEnumerable<PieReview> GetReviewsForPie(int pieId);
    }
}