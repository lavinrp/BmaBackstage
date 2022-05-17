using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    public interface IProgression
    {
        string Name { get; }
        List<ProgressionStage> Stages { get; }
        int CurrentStageNumber { get; }
        ProgressionStage GetCurrentStage();
        double CalculateCompletionPercent();
    }
}
