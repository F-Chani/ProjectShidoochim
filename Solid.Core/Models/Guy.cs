namespace Solid.Core.Models
{
    public class Guy
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public double Heigh { get; set; }
        public string Yeshiva { get; set; }
        public string Sector { get; set; }
        public bool IfGiveFlat { get; set; }
        public List<Proposal> Proposals { get; set; }

    }
}
