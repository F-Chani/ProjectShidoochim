using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Solid.Core.Models;
using Solid.Core.Repositories;

namespace Solid.Data
{
    public class GirlRepository : IGirlRepository
    {
        private readonly DataContext _context;
        public GirlRepository(DataContext context)
        {
            _context = context; 
        }
        public async Task< Girl> GetById(int id)
        {
            return   _context.girls.Find(id);
        }

        public  async Task<List<Girl>> GetAll(string? text = "")
        {
            return  await _context.girls.ToListAsync();
        }

        public  async Task<Girl> Post(Girl girl)
        {
            _context.girls.Add(girl);
            _context.SaveChanges();
            return girl;
        }

        public  async Task<Girl> put(int id, Girl girl)
        {
            var index = await GetById(id);
           index.Name=girl.Name;
            await _context.SaveChangesAsync();
            return index;
        }
        public async Task Delete(int id)
        {
            var index = await GetById(id);
            _context.girls.Remove(index);
            await _context.SaveChangesAsync();

        }

       public async Task<Girl> post(Girl girl)
        {
             _context.girls.Add(girl);
            await _context.SaveChangesAsync();
            return girl;
          
        }
    }
}
