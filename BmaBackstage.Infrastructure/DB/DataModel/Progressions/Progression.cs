using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.DB.DataModel.Progressions
{
    internal class Progression
    {
        public required List<ProgressionStage> Stages { get; set; }
        public required string Name { get; set; }
        public required int CurrentStageNumber { get; set; }
        public required Guid Id { get; set; }
    }
}
