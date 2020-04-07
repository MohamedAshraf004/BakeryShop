using BakeryShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop.Data.Services
{
    public class ChefRepository : IChefRepository
    {
        private readonly AppDbContext _dbContext;

        public ChefRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IEnumerable<Chef> GetChefs => _dbContext.Chefs.OrderBy(n => n.Firstname);

        public Chef GetChefById(int chefId)
        {
            return _dbContext.Chefs.FirstOrDefault(c => c.ChefId == chefId);
        }
        public void UpdateChef(Chef chef)
        {
            _dbContext.Chefs.Update(chef);
        }
        public void CreateChef(Chef chef)
        {
            _dbContext.Chefs.Add(chef);
        }
        public bool Save()
        {
            return _dbContext.SaveChanges() > 0;
        }
    }
}
