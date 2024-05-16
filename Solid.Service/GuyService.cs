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

       
        public async Task<Guy> GetById(int id)
        {
           return await _guyRepository.GetById(id);    
        }
        public async Task<List<Guy>> GetAll(string? text = "")
        {
            //לוגיקה עסקית
            return await _guyRepository.GetAll(text);
        }
        public async Task<Guy> Post(Guy guy)
        {
          return await _guyRepository.Post(guy);
        }

        public async Task<Guy> put(int id, Guy guy)
        {
          return await _guyRepository.put(id, guy); 
        }
        public async Task Delete(int id)
        {
            await _guyRepository.Delete(id);
        }
    }

}
