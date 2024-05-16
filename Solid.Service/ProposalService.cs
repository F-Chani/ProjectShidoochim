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
        public async Task< List<Proposal>> GetAllAsync(string? text = "")
        {
            return  await _ProposalRepository.GetAllAsync(text);   
        }

        public  async Task<Proposal >GetByIdAsync(int id)
        {
            return  await _ProposalRepository.GetByIdAsync(id);
        }

        public async Task<Proposal> PostAsync(Proposal proposal)
        {
           return  await _ProposalRepository.PostAsync(proposal);
        }

        public async Task<Proposal> PutAsync(int id, Proposal proposal)
        {
            return  await _ProposalRepository.PutAsync(id, proposal);   
        }
        public async Task DeleteAsync(int id)
        {
            await _ProposalRepository.DeleteAsync(id);
        }
    }
}
