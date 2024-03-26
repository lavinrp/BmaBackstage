using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities.Progressions
{
    public class Progression : IProgression
    {
        private readonly List<ProgressionStage> m_stages;

        public Progression(string name, List<ProgressionStage> stages, int currentStageNumber)
        {
            Name = name;
            m_stages = stages;
            CurrentStageNumber = currentStageNumber;
        }

        public string Name { get; set; }

        public IReadOnlyCollection<ProgressionStage> Stages => m_stages;

        public int CurrentStageNumber { get; set; }

        public double CalculateCompletionPercent()
        {
            return (double)Stages.Count / CurrentStageNumber;
        }

        public ProgressionStage GetCurrentStage()
        {
            return m_stages[CurrentStageNumber];
        }

        /// <summary>
        /// Unique identifier 
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
