using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using SiteManagementApi.Business.Interfaces;
using SiteManagementApi.Data.Context;
using SiteManagementApi.DatabaseContext.Context;
using SiteManagementApi.Entities.Entities;
using SiteManagementApi.Entities.Entities.General;
using SiteManagementApi.Entities.Entities.Persons;

namespace SiteManagementApi.Operation.OperationManager
{
    public class PersonOperation : IPerson
    {
        public PersonGeneralInfo GetByGeneralPersonId(int personId)
        {
            throw new NotImplementedException();
        }

        public PersonApartment GetByPersonApartment(int personId)
        {
            throw new NotImplementedException();
        }

        public PersonCommunication GetByPersonCommunication(int personId)
        {
            throw new NotImplementedException();
        }

        public PersonDetail GetByPersonDetail(int personId)
        {
            throw new NotImplementedException();
        }

        public Person GetByPersonId(int personId)
        {
            throw new NotImplementedException();
        }

        public PersonIdentityInformation GetByPersonIdentityInformation(int personId)
        {
            throw new NotImplementedException();
        }

        public PersonVehicle GetByPersonVehicle(int personId)
        {
            throw new NotImplementedException();
        }

        public WaitingApprovePerson GetByWaitingApprovePerson(int personId)
        {
            throw new NotImplementedException();
        }

        public  List<PersonGeneralInfo> GetGeneralPersonsAll()
        {
            //SpCall sp = new SpCall("Dasboard.Get_Persons");

            List<PersonGeneralInfo> personListResponse = new List<PersonGeneralInfo>();
            //DashboardContext sContext = new DashboardContext();
            //using (sContext)
            //{
            //    List<PersonGeneralInfo> personList = new List<PersonGeneralInfo>();
            //    PersonGeneralInfo personGeneralInfo = new PersonGeneralInfo();
            //    personList = sContext.personGeneralInfos.FromSqlRaw(sp.ToString()).ToList();
            //    foreach (PersonGeneralInfo personGeneral in personList)
            //    {
            //        PersonGeneralInfo pg = new PersonGeneralInfo();
            //        pg.person.PersonId = personGeneral.person.PersonId;
            //        personListResponse.Add(pg);
            //    }
            //}
            return personListResponse;
        }

        public List<PersonApartment> GetPersonApartmentsAll()
        {
            throw new NotImplementedException();
        }

        public List<PersonCommunication> GetPersonCommunicationsAll()
        {
            throw new NotImplementedException();
        }

        public List<PersonDetail> GetPersonDetailAll()
        {
            throw new NotImplementedException();
        }

        public List<PersonIdentityInformation> GetPersonIdentityInformationAll()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetPersonsListAll()
        {
            throw new NotImplementedException();
        }

        public List<PersonVehicle> GetPersonVehicleAll()
        {
            throw new NotImplementedException();
        }

        public List<WaitingApprovePerson> GetWaitingApprovePeopleAll()
        {
            throw new NotImplementedException();
        }

        public string PersonApartmentDelete(int personId)
        {
            throw new NotImplementedException();
        }

        public string PersonApartmentSave(PersonApartment personApartment)
        {
            throw new NotImplementedException();
        }

        public string PersonApartmentUpdate(PersonApartment personApartment)
        {
            throw new NotImplementedException();
        }

        public string PersonCommunicationDelete(int personId)
        {
            throw new NotImplementedException();
        }

        public string PersonCommunicationSave(PersonCommunication personCommunication)
        {
            throw new NotImplementedException();
        }

        public string PersonCommunicationUpdate(PersonCommunication personCommunication)
        {
            throw new NotImplementedException();
        }

        public string PersonDelete(int PersonId)
        {
            throw new NotImplementedException();
        }

        public string PersonDetailDelete(int personId)
        {
            throw new NotImplementedException();
        }

        public string PersonDetailSave(PersonDetail personDetail)
        {
            throw new NotImplementedException();
        }

        public string PersonDetailUpdate(PersonDetail personDetail)
        {
            throw new NotImplementedException();
        }

        public string PersonGeneralDelete(int PersonId)
        {
            throw new NotImplementedException();
        }

        public string PersonGeneralSave(PersonGeneralInfo personGeneralInfo)
        {
            throw new NotImplementedException();
        }

        public string PersonGeneralUpdate(PersonGeneralInfo personGeneralInfo)
        {
            throw new NotImplementedException();
        }

        public string PersonIdentityInformationDelete(int personId)
        {
            throw new NotImplementedException();
        }

        public string PersonIdentityInformationSave(PersonIdentityInformation personIdentityInformation)
        {
            throw new NotImplementedException();
        }

        public string PersonIdentityInformationUpdate(PersonIdentityInformation personIdentityInformation)
        {
            throw new NotImplementedException();
        }

        public string PersonSave(Person person)
        {
            throw new NotImplementedException();
        }

        public string PersonUpdate(Person person)
        {
            throw new NotImplementedException();
        }

        public string PersonVehicleDelete(int personId)
        {
            throw new NotImplementedException();
        }

        public string PersonVehicleSave(PersonVehicle personVehicle)
        {
            throw new NotImplementedException();
        }

        public string PersonVehicleUpdate(PersonVehicle personVehicle)
        {
            throw new NotImplementedException();
        }

        public string WaitingApprovePersonDelete(int personId)
        {
            throw new NotImplementedException();
        }

        public string WaitingApprovePersonSave(WaitingApprovePerson waitingApprovePerson)
        {
            throw new NotImplementedException();
        }

        public string WaitingApprovePersonUpdate(WaitingApprovePerson waitingApprovePerson)
        {
            throw new NotImplementedException();
        }
    }
}
