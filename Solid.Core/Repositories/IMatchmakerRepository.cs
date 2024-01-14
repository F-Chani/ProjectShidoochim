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
        List<Matchmaker> GetAll(string? text = "");
        Matchmaker GetById(int id);
        void Delete(int id);
        Matchmaker Post(Matchmaker matchmaker);
        Matchmaker put(int id, Matchmaker matchmaker);
    }
}
