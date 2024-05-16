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

        Task<List<Girl>> GetAll(string? text = "");
        Task<Girl> GetById(int id);
        Task Delete(int id);
        Task<Girl> Post(Girl girl);
        Task<Girl> put(int id, Girl girl);
    }
}
