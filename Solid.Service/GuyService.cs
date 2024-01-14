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
    public class GuyService : IGuyService
    {
        private readonly IGuyRepository _guyRepository;
        public GuyService(IGuyRepository guyRepository)
        {
            _guyRepository = guyRepository;
        }

        public void Delete(int id)
        {
            _guyRepository.Delete(id);
        }
        public Guy GetById(int id)
        {
           return _guyRepository.GetById(id);    
        }
        public List<Guy> GetAll(string? text = "")
        {
            //לוגיקה עסקית
            return _guyRepository.GetAll(text);
        }
        public void Post(Guy guy)
        {
            _guyRepository.Post(guy);
        }

        public void put(int id, Guy guy)
        {
       _guyRepository.put(id, guy); 
        }
    }

}
