using Microsoft.EntityFrameworkCore;
using Solid.Core.Models;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Solid.Data
{
    public class GuyRepository : IGuyRepository
    {
        private readonly DataContext _context;
        public GuyRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Guy> GetById(int id)
        {
            return _context.guys.Find(id);
        }
        public async Task<List<Guy>> GetAll(string? text = "")
        {
            //לוגיקה עסקית
            return await _context.guys.ToListAsync();
        }
        public async Task<Guy> Post(Guy guy)
        {
            _context.guys.Add(guy);
            await _context.SaveChangesAsync();
            return guy;
        }

        public async Task<Guy> Put(int id, Guy guy)
        {
            var index = await GetById(id);
            index.Name = guy.Name;
              await _context.SaveChangesAsync();
            return index;
        }
        public async Task Delete(int id)
        {
            var guy =await GetById(id);
            _context.guys.Remove(guy);
            await _context.SaveChangesAsync();
        }
    }
}

