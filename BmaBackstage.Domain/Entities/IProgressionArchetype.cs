using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    public interface IProgressionArchetype
    {
        string Name { get; set; }
        List <IProgressionStageArchetype> Stages { get; set; }
        IProgression CreateProgression();
    }
}
