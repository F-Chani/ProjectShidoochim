using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IGirlService
    {
        List<Girl> GetAll(string? text = "");
        Girl GetById(int id);
        void Delete(int id);
        void Post(Girl girl);
        void put(int id, Girl girl);
    }
}
