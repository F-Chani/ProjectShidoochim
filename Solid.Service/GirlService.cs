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
    public class GirlService : IGirlService
    {
        private readonly IGirlRepository _girlRepository;
        public GirlService(IGirlRepository girlRepository)
        {
            _girlRepository = girlRepository;
        }
        public async Task Delete(int id)
        {
           await _girlRepository.Delete(id);
        }

        public  async Task<Girl> GetById(int id)
        {
            return await _girlRepository.GetById(id);
        }

        public  async Task<List<Girl>> GetAll(string? text = "")
        {
            
            return await _girlRepository.GetAll(text);
        }

        public async Task<Girl> Post(Girl girl)
        {
           return await _girlRepository.Post(girl);
        }

        public async Task<Girl> put(int id, Girl girl)
        {
            return await _girlRepository.put(id, girl);
        }

        async  Task<Girl> IGirlService.Post(Girl girl)
        {
          return await  _girlRepository.Post(girl);
            
        }
    }
}
