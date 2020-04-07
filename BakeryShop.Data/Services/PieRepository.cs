using BakeryShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop.Data.Services
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _dbContext;

        public PieRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public IEnumerable<Pie> AllPies => _dbContext.Pies.OrderBy(p=>p.Name);
        public IEnumerable<Pie> PiesOfTheWeek => _dbContext.Pies.Where(p => p.IsPieOfTheWeek).ToList();
       
        public Pie GetPieById(int pieId)
        {
            var pie = _dbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
            return pie;
        }

        public void CreatePie(Pie pie)
        {
            _dbContext.Pies.Add(pie);
        }
        public void UpdatePie(Pie pie)
        {
            _dbContext.Pies.Update(pie);
        }
        public bool Save()
        {
           return _dbContext.SaveChanges() > 0;
        }
    }
}
