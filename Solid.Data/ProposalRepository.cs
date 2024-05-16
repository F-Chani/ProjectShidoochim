using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Models;
using Solid.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Solid.Data
{
    public class ProposalRepository:IProposalRepository
    {
        private readonly DataContext _context;

        public ProposalRepository(DataContext context)
        {
            _context = context;
        }

        public  async Task<Proposal> GetByIdAsync(int id)
        {
            return  _context.proposal.Find(id);
        }
        public async Task< List<Proposal>> GetAllAsync(string? text = "")
        {
            return await _context.proposal.Include(x => x.Guy).Include(x => x.Girl).ToListAsync();
        }

        public  async Task<Proposal> PostAsync(Proposal proposal)
        {
            _context.proposal.Add(proposal);
            await _context.SaveChangesAsync();
            return proposal;
        }

        public async Task< Proposal> PutAsync(int id, Proposal proposal)
        {
            var index =  await GetByIdAsync(id);
            index = proposal;
             await  _context.SaveChangesAsync();
            return proposal;
        }
        public async Task  DeleteAsync(int id)
        {
            var proposal =  await GetByIdAsync(id);
            _context.proposal.Remove(proposal);
           await _context.SaveChangesAsync();
        }

    }
}
