using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IGuyService
    {
        Task<List<Guy>> GetAll(string? text = "");
        Task<Guy> GetById(int id);
        Task Delete(int id);
        Task<Guy> Post(Guy guy);
        Task<Guy> Put(int id, Guy guy);
    }
}
