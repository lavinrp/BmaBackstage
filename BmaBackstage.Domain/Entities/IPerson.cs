using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Any Person involved with the dojo
    /// </summary>
    interface IPerson
    {
        string Name { get; set;}
        DateTime BirthDay { get; set; }
        List<EmergencyContact> EmergencyContacts { get; }
    }
}
