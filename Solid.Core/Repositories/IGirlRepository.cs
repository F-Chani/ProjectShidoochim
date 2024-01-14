using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IGirlRepository
    {

        List<Girl> GetAll(string? text = "");
        Girl GetById(int id);
        void Delete(int id);
        Girl Post(Girl girl);
        Girl put(int id, Girl girl);
    }
}
