using SiteManagementApi.Entities.Entities.Persons;

namespace SiteManagementApi.Entities.Entities.General
{
    public class PersonGeneralInfo
    {
        public Person? person { get; set; }
         
        public Address? personAddress { get; set; } 
        public PersonApartment? personApartment { get; set; }    
        public PersonCommunication? personCommunication { get; set; }
        public PersonDetail? personDetail { get; set; }
        public PersonIdentityInformation? personIdentityInformation { get; set; }
        public PersonVehicle? personVehicle { get; set; }
        public WaitingApprovePerson? waitingApprovePerson { get; set; }

    }
}
