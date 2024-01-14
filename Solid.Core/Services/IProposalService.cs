using Solid.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IProposalService
    {
        List<Proposal> GetAll(string? text = "");
        Proposal GetById(int id);
        void Delete(int id);
        Proposal Post(Proposal proposal);
        Proposal put(int id, Proposal proposal);
    }
}
