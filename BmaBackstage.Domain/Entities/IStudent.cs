using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    public interface IStudent : IMartialArtist
    {
        DateTime ContractStart { get; set; }
        DateTime ContractEnd { get; set; }
        List<string> SpecialNeeds { get; set; }
        List<string> Notes { get; set; }
    }
}
