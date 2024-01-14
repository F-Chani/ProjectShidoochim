using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Girl GetById(int id)
        {
            return _context.girls.Find(id);
        }

        public List<Girl> GetAll(string? text = "")
        {
            return _context.girls.ToList();
        }

        public Girl Post(Girl girl)
        {
            _context.girls.Add(girl);
            _context.SaveChanges();
            return girl;
        }

        public Girl put(int id, Girl girl)
        {
            var index = GetById(id);
           index.Name=girl.Name;

            _context.SaveChanges();
            return index;
        }
        public void Delete(int id)
        {
            var index = GetById(id);
            _context.girls.Remove(index);
            _context.SaveChanges();
        }
    }
}
