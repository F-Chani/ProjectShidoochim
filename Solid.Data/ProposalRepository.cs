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

        public Proposal GetById(int id)
        {
            return _context.proposal.Find(id);
        }
        public List<Proposal> GetAll(string? text = "")
        {
            return _context.proposal.Include(x=>x.Guy).Include(x=>x.Girl).ToList();
        }

        public Proposal Post(Proposal proposal)
        {
            _context.proposal.Add(proposal);
            _context.SaveChanges();
            return proposal;
        }

        public Proposal put(int id, Proposal proposal)
        {
            var index = GetById(id);
            index.Id = proposal.Id;
            _context.SaveChanges();
            return proposal;
        }
        public void Delete(int id)
        {
            var proposal = GetById(id);
            _context.proposal.Remove(proposal);
            _context.SaveChanges();
        }

    }
}
