using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    public interface IProgressionStageArchetype
    {
        string Name { get; set; }
        List<IRequirement> Requirements { get; set; }
        ProgressionStage CreateProgressionStage();
    }
}
