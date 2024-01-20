using Microsoft.AspNetCore.Mvc;
using SiteManagementApi.Entities.Entities;
using SiteManagementApi.Entities.Entities.General;
using SiteManagementApi.Entities.Entities.Persons;
using SiteManagementApi.Entities.Entities.Site;
using SiteManagementApi.Entities.Entities.User;
using SiteManagementApi.Operation.OperationManager;

namespace SiteManagementApi.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet("")]
        public int abc()
        {
            //return UserOperation.GetUserInfo();
            return 0;
        }
        [HttpGet("GetPersonAll")]
        public List<Person> GetPersonAll() {
            PersonOperation operation = new PersonOperation();
            List<Person> persons = operation.GetPersonsListAll();
            return persons;
        }
        [HttpGet("GetPersonApartmentAll")]
        public List<PersonApartment> GetPersonApartmentAll()
        {
            PersonOperation operation = new PersonOperation();
            List<PersonApartment> persons = operation.GetPersonApartmentsAll();
            return persons;
        }
        [HttpPost("GeneralPersonSave")]
        public int GeneralPersonSave(PersonGeneralInfo request)
        {
            int res = 0;
            PersonOperation operation = new PersonOperation();
            PersonGeneralInfo personGeneralInfo = new PersonGeneralInfo();

            Person person = new Person();
            person.FirstName = request.person.FirstName;
            person.LastName = request.person.LastName;
            person.PersonType = request.person.PersonType;
            person.CreatedUserName = request.person.CreatedUserName;
            personGeneralInfo.person = new Person();
            personGeneralInfo.person = person;

            PersonDetail personDetail = new PersonDetail();
            personDetail.Gender = request.personDetail.Gender;
            personDetail.EducationType = request.personDetail.EducationType;
            personDetail.Description = request.personDetail.Description;
            personDetail.CardNumber = request.personDetail.CardNumber;
            personDetail.JobDescriptionId = request.personDetail.JobDescriptionId;
            personDetail.PrivateInsurance = request.personDetail.PrivateInsurance;
            personDetail.MartyrVeteranRelative = request.personDetail.MartyrVeteranRelative;
            personDetail.PetType = request.personDetail.PetType;

            PersonIdentityInformation personIdent = new PersonIdentityInformation();
            personIdent.IdentityNumber = request.personIdentityInformation.IdentityNumber;
            personIdent.TaxNumber = request.personIdentityInformation.TaxNumber;
            personIdent.PassportNumber = request.personIdentityInformation.PassportNumber;
            personIdent.Nationality = request.personIdentityInformation.Nationality;
            personIdent.FatherName = request.personIdentityInformation.FatherName;
            personIdent.MotherName = request.personIdentityInformation.MotherName;
            personIdent.BirthDate = request.personIdentityInformation.BirthDate;
            personIdent.BirthPlace = request.personIdentityInformation.BirthPlace;
            personIdent.MaritalDate = request.personIdentityInformation.MaritalDate;
            personIdent.MaritalStatus = request.personIdentityInformation.MaritalStatus;
            personIdent.HomeTown = request.personIdentityInformation.HomeTown;
            personIdent.BloodType = request.personIdentityInformation.BloodType;

            PersonCommunication communication = new PersonCommunication();
            communication.Communication = request.personCommunication.Communication;
            communication.CommunicationType = request.personCommunication.CommunicationType;
            communication.IsPrimary = request.personCommunication.IsPrimary;

            PersonApartment apartment = new PersonApartment();
            apartment.Ownership = request.personApartment.Ownership;
            apartment.EntryDate = request.personApartment.EntryDate;
            apartment.RelatedPerson = request.personApartment.RelatedPerson;
            apartment.BankPaymentCode = request.personApartment.BankPaymentCode;
            apartment.ApartmentId = request.personApartment.ApartmentId;
            apartment.Description = request.personApartment.Description;

            Address address = new Address();
            address.CountryCode = request.personAddress.CountryCode;
            address.CityCode = request.personAddress.CityCode;
            address.DistrictCode = request.personAddress.DistrictCode;
            address.Quarter = request.personAddress.Quarter;
            address.OpenAddress = request.personAddress.OpenAddress;

            PersonVehicle vehicle = new PersonVehicle();
            vehicle.Plate = request.personVehicle.Plate;
            vehicle.Brand = request.personVehicle.Brand;
            vehicle.Model = request.personVehicle.Model;
            vehicle.Color = request.personVehicle.Color;

            if (request.IsEmployee == true)
            {
                Employee employee = new Employee();
                employee.Company = request.employee.Company;
                employee.Position = request.employee.Position;
                employee.MealCard = request.employee.MealCard;
                employee.Description = request.employee.Description;

                EmployeeBankInfo employeeBankInfo = new EmployeeBankInfo();
                employeeBankInfo.Bank = request.employeeBankInfo.Bank;
                employeeBankInfo.AccountNumber =  request.employeeBankInfo.AccountNumber;
                employeeBankInfo.IBAN = request.employeeBankInfo.IBAN;
            }

            

            res = operation.PersonSave(person);
            return res;
        }
    }
}

