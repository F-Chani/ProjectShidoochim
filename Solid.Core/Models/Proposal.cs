using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Models
{
    public class Proposal
    {
        public int Id { get; set; }
        public Guy Guy { get; set; }
        public Girl Girl { get; set; }
        public DateTime date { get; set; }


    }
}
