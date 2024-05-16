using Microsoft.EntityFrameworkCore;
using Solid.Core.Models;


namespace Solid.Data
{
    public interface IDataContext
    {
        DbSet<Girl> girls { get; set; }
        DbSet<Guy> guys { get; set; }
        DbSet<Matchmaker> matchmakers { get; set; }
        DbSet<Proposal> proposal { get; set; }
    }
}