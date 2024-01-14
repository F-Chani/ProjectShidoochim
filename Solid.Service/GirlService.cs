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
        public void Delete(int id)
        {
            _girlRepository.Delete(id);
        }

        public Girl GetById(int id)
        {
            return _girlRepository.GetById(id);
        }

        public List<Girl> GetAll(string? text = "")
        {
            //לוגיקה עסקית
            return _girlRepository.GetAll(text);
        }

        public void Post(Girl girl)
        {
            _girlRepository.Post(girl);
        }

        public void put(int id, Girl girl)
        {
            _girlRepository.put(id, girl);
        }
    }
}
