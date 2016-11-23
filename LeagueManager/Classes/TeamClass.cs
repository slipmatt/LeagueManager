using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork;
using LeagueManager.Data;

namespace LeagueManager.Classes
{
    
    public class TeamClass
    {
        private static IUow _uow;
        private static IRepository<Team> _repo;
        public TeamClass(IUow uow)
        {
            _uow = uow;
            _repo = _uow.GetRepo<Team>();
        }

        public IQueryable<Team> GetAllTeams()
        {
            return _repo.GetByIQuerable(teamDetails => teamDetails.TeamName != null)
                .Take(250)
                .AsQueryable();
        }
    }
}
