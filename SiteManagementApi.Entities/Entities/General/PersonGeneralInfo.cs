using SiteManagementApi.Entities.Entities.Persons;
using SiteManagementApi.Entities.Entities.Site;

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
        public Employee? employee { get; set; }
        public EmployeeBankInfo? employeeBankInfo { get; set; }
        public bool? IsEmployee { get; set; }

    }
}
