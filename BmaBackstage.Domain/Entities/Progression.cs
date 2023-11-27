using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    public class Progression : IProgression
    {
        public Progression(string name, List<ProgressionStage> stages, int currentStageNumber)
        {
            Name = name;
            Stages = stages;
            CurrentStageNumber = currentStageNumber;
        }

        public string Name { get; set; }

        public List<ProgressionStage> Stages { get; set; }

        public int CurrentStageNumber { get; set; }

        public double CalculateCompletionPercent()
        {
            return (double)Stages.Count / CurrentStageNumber;
        }

        public ProgressionStage GetCurrentStage()
        {
            return Stages[CurrentStageNumber];
        }

        /// <summary>
        /// Unique identifier 
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
