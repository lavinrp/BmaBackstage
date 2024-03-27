using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.DB.DataModel.Progressions.Requirements
{
    internal class ManualApprovalRequirement : Requirement
    {
        public required bool Passed { get ; set; }
    }
}
