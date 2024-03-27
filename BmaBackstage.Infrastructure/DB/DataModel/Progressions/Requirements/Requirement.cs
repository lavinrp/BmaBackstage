using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.DB.DataModel.Progressions.Requirements
{
    internal class Requirement
    {
        public required string Name { get; set; }

        public required Guid Id { get; set; }
    }
}
