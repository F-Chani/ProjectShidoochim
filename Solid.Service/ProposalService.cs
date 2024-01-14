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
    public class ProposalService : IProposalService
    {
        private readonly IProposalRepository _ProposalRepository;
        public ProposalService(IProposalRepository proposalRepository)
        {
            _ProposalRepository= proposalRepository;    
        }
        public List<Proposal> GetAll(string? text = "")
        {
            return  _ProposalRepository.GetAll(text);   
        }

        public Proposal GetById(int id)
        {
            return _ProposalRepository.GetById(id);
        }

        public Proposal Post(Proposal proposal)
        {
           return _ProposalRepository.Post(proposal);
        }

        public Proposal put(int id, Proposal proposal)
        {
            return _ProposalRepository.put(id, proposal);   
        }
        public void Delete(int id)
        {
            _ProposalRepository.Delete(id);
        }
    }
}
