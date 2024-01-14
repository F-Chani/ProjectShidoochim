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
       
        public Matchmaker GetById(int id)
        {
            return _context.matchmakers.Find(id);
        }

        public List<Matchmaker> GetAll(string? text = "")
        {
            //לוגיקה עסקית
            return (List<Matchmaker>)_context.matchmakers.Include(x=>x.Proposals).ThenInclude(x=>x.Guy).ToList();
        }

        public Matchmaker Post(Matchmaker matchmaker)
        {
            _context.matchmakers.Add(matchmaker);
            _context.SaveChanges();
            return matchmaker;
        }

        public Matchmaker put(int id, Matchmaker matchmaker)
        {
            var index = GetById(id);
            index.Name=matchmaker.Name;
            _context.SaveChanges();
            return matchmaker;
        }
        public void Delete(int id)
        {
            var matchmaker = GetById(id);
            _context.matchmakers.Remove(matchmaker);
            _context.SaveChanges();
        }

    }
}
