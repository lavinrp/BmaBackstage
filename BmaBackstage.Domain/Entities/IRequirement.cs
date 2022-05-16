using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    interface IRequirement
    {
        string Name { get; }
        bool Passed { get; }
        double CalculateCompletionPercent();
    }
}
