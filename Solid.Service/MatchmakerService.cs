using Solid.Core.Models;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class MatchmakerService: IMatchmakerService
    {
        private readonly IMatchmakerRepository _MatchmakerRepository;
        public MatchmakerService(IMatchmakerRepository matchmakerRepository)
        {
            _MatchmakerRepository = matchmakerRepository;   
        }
        public void Delete(int id)
        {
            _MatchmakerRepository.Delete(id);
        }

        public Matchmaker GetById(int id)
        {
            return _MatchmakerRepository.GetById(id);
        }

        public List<Matchmaker> GetAll(string? text = "")
        {
            //לוגיקה עסקית
            return _MatchmakerRepository.GetAll(text);
        }

        public void Post(Matchmaker matchmaker)
        {
            _MatchmakerRepository.Post(matchmaker);
        }

        public void put(int id, Matchmaker matchmaker)
        {
       
            _MatchmakerRepository.put(id, matchmaker);
        }
    }
}
