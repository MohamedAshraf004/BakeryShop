using BakeryShop.Core.Models;
using System.Collections.Generic;

namespace BakeryShop.Data.Services
{
    public interface IChefRepository
    {
        IEnumerable<Chef> GetChefs { get; }

        void CreateChef(Chef chef);
        Chef GetChefById(int chefId);
        bool Save();
        void UpdateChef(Chef chef);
    }
}