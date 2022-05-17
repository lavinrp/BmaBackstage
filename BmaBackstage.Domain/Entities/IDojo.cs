using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Training hall
    /// </summary>
    public interface IDojo
    {
        /// <summary>
        /// Physical location of the dojo
        /// </summary>
        string Address { get; }

        /// <summary>
        /// Human readable name for the dojo
        /// </summary>
        string Name { get; }
    }
}
