using BakeryShop.Core.Models;
using System.Collections.Generic;

namespace BakeryShop.Data.Services
{
    public interface ITeamRepository
    {
        List<Team> GetTeams { get; }

        void AddChefToTeam(int chefId, int teamId);
        void CreateTeam(Team team);
        Team GetTeamById(int teamId);
        void ReemoveChefToTeam(int chefId, int teamId);
        bool Save();
        void UpdateTeam(Team team);
    }
}