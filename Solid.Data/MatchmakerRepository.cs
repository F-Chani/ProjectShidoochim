using Solid.Core.Models;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Solid.Data
{
    public class MatchmakerRepository : IMatchmakerRepository
    {
        private readonly DataContext _context;

        public MatchmakerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Matchmaker> GetById(int id)
        {
            return await _context.matchmakers.Find(id);
        }

        public async Task<List<Matchmaker>> GetAll(string? text = "")
        {

            return await _context.matchmakers.Include(x => x.Proposals).ThenInclude(x => x.Guy).ToList();
        }

        public async Task<Matchmaker> Post(Matchmaker matchmaker)
        {
            _context.matchmakers.Add(matchmaker);
            await _context.SaveChangesAsync();
            return matchmaker;
        }

        public async Task<Matchmaker> Put(int id, Matchmaker matchmaker)
        {
            var index = await GetById(id);
            index.Name = matchmaker.Name;
            await _context.SaveChangesAsync();
            return matchmaker;
        }
        public async Task Delete(int id)
        {
            var matchmaker = await GetById(id);
            _context.matchmakers.Remove(matchmaker);
            await _context.SaveChangesAsync();
        }

    }
}
