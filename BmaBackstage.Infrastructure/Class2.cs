using BmaBackstage.Domain.Entities;

namespace BmaBackstage.Infrastructure
{
    public class Class2 : Domain.Entities.IPerson
    {
        public string Name => "Infrastructure";

        public DateTime BirthDay => DateTime.Now;

        public List<EmergencyContact> EmergencyContacts => throw new NotImplementedException();
    }
}