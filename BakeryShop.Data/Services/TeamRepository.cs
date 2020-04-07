using BakeryShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryShop.Data.Services
{
    public class TeamRepository : ITeamRepository
    {
        private readonly AppDbContext _dbContext;

        public TeamRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public List<Team> GetTeams => _dbContext.Teams.OrderBy(t => t.TeamId).ToList();
        public Team GetTeamById(int teamId)
        {
            return _dbContext.Teams.FirstOrDefault(t => t.TeamId == teamId);
        }
        public void CreateTeam(Team team)
        {
            _dbContext.Teams.Add(team);
        }
        public void UpdateTeam(Team team)
        {
            _dbContext.Teams.Update(team);
        }
        public void AddChefToTeam(int chefId, int teamId)
        {
            var chef = _dbContext.Chefs.Find(chefId);
            var team = _dbContext.Teams.Find(teamId);
            team.Chefs.Add(chef);
        }
        public void ReemoveChefToTeam(int chefId, int teamId)
        {
            var chef = _dbContext.Chefs.Find(chefId);
            var team = _dbContext.Teams.Find(teamId);
            team.Chefs.Remove(chef);
        }
        public bool Save()
        {
            return _dbContext.SaveChanges() > 0;
        }
    }
}
