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
    public class MatchmakerService : IMatchmakerService
    {
        private readonly IMatchmakerRepository _MatchmakerRepository;
        public MatchmakerService(IMatchmakerRepository matchmakerRepository)
        {
            _MatchmakerRepository = matchmakerRepository;
        }
        public async Task Delete(int id)
        {
            await _MatchmakerRepository.Delete(id);
        }

        public async Task<Matchmaker> GetById(int id)
        {
            return await _MatchmakerRepository.GetById(id);
        }

        public async Task<List<Matchmaker>> GetAll(string? text = "")
        {
            //לוגיקה עסקית
            return await _MatchmakerRepository.GetAll(text);
        }

        public async Task<Matchmaker> Post(Matchmaker matchmaker)
        {
            return await _MatchmakerRepository.Post(matchmaker);
        }

        public async Task<Matchmaker> Put(int id, Matchmaker matchmaker)
        {
            return await _MatchmakerRepository.Put(id,matchmaker);
        }
    }
}
