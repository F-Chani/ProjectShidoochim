using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IProposalRepository
    {
        Task<List<Proposal>> GetAllAsync(string? text = "");
        Task<Proposal> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task<Proposal> PostAsync(Proposal proposal);
        Task<Proposal> PutAsync(int id, Proposal proposal);
    }
}
