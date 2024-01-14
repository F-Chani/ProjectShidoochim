namespace Solid.Core.Models
{
    public class Matchmaker
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int ExperienceYear { get; set; }
        public List<Proposal> Proposals { get; set; }

    }
}
