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
      
        public Guy GetById(int id)
        {
            return _context.guys.Find(id);
        }
        public List<Guy> GetAll(string? text = "")
        {
            //לוגיקה עסקית
            return _context.guys.ToList();
        }
        public Guy Post(Guy guy)
        {
            _context.guys.Add(guy);
            _context.SaveChanges();
            return guy;
        }

        public Guy put(int id, Guy guy)
        {
            var index = GetById(id);
           index.Name=guy.Name;
            _context.SaveChanges();
            return index;
        }
        public void Delete(int id)
        {
            var guy = GetById(id);
            _context.guys.Remove(guy);
            _context.SaveChanges();
        }
    }
}

