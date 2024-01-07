using SiteManagementApi.Entities.Entities;
using SiteManagementApi.Entities.Entities.General;
using SiteManagementApi.Entities.Entities.Persons;
using SiteManagementApi.Entities.Entities.User;
using System.Collections.Generic;

namespace SiteManagementApi.Business.Interfaces
{
    public interface IPerson
    {
        List<PersonGeneralInfo> GetGeneralPersonsAll();                                                     // Tüm 'Person' ile bağlantılı bilgilerini getirir(adres,iletişim vb.)
        PersonGeneralInfo GetByGeneralPersonId(int personId);                                               // PersonId ile tüm  bilgileri getirir. xx
        string PersonGeneralSave(PersonGeneralInfo personGeneralInfo);                                      // Person kaydetme methodu
        string PersonGeneralUpdate(PersonGeneralInfo personGeneralInfo);                                    // Person Update
        string PersonGeneralDelete(int PersonId);                                                           // Person Delete


        List<Person> GetPersonsListAll();                                                                   // Person bilgilerini getirir.
        Person GetByPersonId(int personId);                                                                 // PersonId ile bağlantılı Person bilgisini getirir. xx
        string PersonSave(Person person);
        string PersonUpdate(Person person);
        string PersonDelete(int PersonId);


        List<PersonApartment> GetPersonApartmentsAll();                                                     // Tüm apartman bilgilerini getirir.
        PersonApartment GetByPersonApartment(int personId);                                                 // PersonId ile kişiye ait apartman bilgilerini getirir. xx
        string PersonApartmentSave(PersonApartment personApartment);
        string PersonApartmentUpdate(PersonApartment personApartment);
        string PersonApartmentDelete(int personId);

        List<PersonCommunication> GetPersonCommunicationsAll();                                             // Tüm kişi bilgileri listesi
        PersonCommunication GetByPersonCommunication(int personId);                                         // PersonId ile kişi bilgilerini getirir.  xx
        string PersonCommunicationSave(PersonCommunication personCommunication);
        string PersonCommunicationUpdate(PersonCommunication personCommunication);
        string PersonCommunicationDelete(int personId);

        List<PersonDetail> GetPersonDetailAll();                                                            // Tüm kişi detay bilgileri listesi  
        PersonDetail GetByPersonDetail(int personId);                                                       // PersonId ile detay bilgileri listesi  xx
        string PersonDetailSave(PersonDetail personDetail);
        string PersonDetailUpdate(PersonDetail personDetail);
        string PersonDetailDelete(int personId);


        List<PersonIdentityInformation> GetPersonIdentityInformationAll();                                  // Tüm Kişi kimlik bilgilerini getirir.
        PersonIdentityInformation GetByPersonIdentityInformation(int personId);                             // PersonId ile Kişi kimlik bilgilerini getirir. xx
        string PersonIdentityInformationSave(PersonIdentityInformation personIdentityInformation);
        string PersonIdentityInformationUpdate(PersonIdentityInformation personIdentityInformation);
        string PersonIdentityInformationDelete(int personId);

        List<PersonVehicle> GetPersonVehicleAll();                                                          // Tüm kişi araç bilgilerini getirir.
        PersonVehicle GetByPersonVehicle(int personId);                                                    // PersonId ile kişinin araç bilgilerini getirir. xx
        string PersonVehicleSave(PersonVehicle personVehicle);
        string PersonVehicleUpdate(PersonVehicle personVehicle);
        string PersonVehicleDelete(int personId);

        List<WaitingApprovePerson> GetWaitingApprovePeopleAll();                                            // Tüm onaydaki listeyi getirir.
        WaitingApprovePerson GetByWaitingApprovePerson(int personId);                                       // PErsonId ile bekleyen onay bilgielrini getirir.  xx
       string WaitingApprovePersonSave(WaitingApprovePerson waitingApprovePerson);
       string WaitingApprovePersonUpdate(WaitingApprovePerson waitingApprovePerson);
       string WaitingApprovePersonDelete(int personId);


    }
}
