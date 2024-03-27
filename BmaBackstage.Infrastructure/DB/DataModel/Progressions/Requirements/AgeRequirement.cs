using BmaBackstage.Infrastructure.DB.DataModel.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.DB.DataModel.Progressions.Requirements
{
    internal class AgeRequirement : Requirement
    {
        public required Person Person { get; set; }
        public required int RequiredAge { get; set; }
    }
}
