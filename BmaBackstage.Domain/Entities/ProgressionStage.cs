using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    class ProgressionStage
    {
        ProgressionStage(string name) : this(name, new List<IRequirement>())
        {
        }

        ProgressionStage(string name, List<IRequirement> requirements)
        {
            Name = name;
            Requirements = requirements;
        }

        public string Name { get; private set; }
        public List<IRequirement> Requirements { get; private set; }
        bool IsComplete()
        {
            return Requirements.All(x => x.Passed);
        }
    }
}
