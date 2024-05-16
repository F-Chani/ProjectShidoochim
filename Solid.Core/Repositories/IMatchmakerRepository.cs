using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IMatchmakerRepository
    {
         Task<List<Matchmaker>> GetAll(string? text = "");
        Task<Matchmaker> GetById(int id);
        Task Delete(int id);
        Task<Matchmaker> Post(Matchmaker matchmaker);
        Task<Matchmaker> Put(int id, Matchmaker matchmaker);
    }
}
