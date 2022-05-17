using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Person training in any system
    /// </summary>
    public interface IMartialArtist
    {
        /// <summary>
        /// Progressions that this person is training in.
        /// </summary>
        /// <example>Karate Belts, Instructor Certification, etc...</example>
        List<IProgression> Progressions { get; }
    }
}
