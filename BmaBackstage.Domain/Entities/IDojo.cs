using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    public interface IDojo
    {
        string Address { get; }
        string Name { get; }
    }
}
