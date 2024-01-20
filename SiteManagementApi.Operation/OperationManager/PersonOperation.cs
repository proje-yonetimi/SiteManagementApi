using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SiteManagementApi.Business.Interfaces;
using SiteManagementApi.Data.Context;
using SiteManagementApi.Entities.Entities;
using SiteManagementApi.Entities.Entities.General;
using SiteManagementApi.Entities.Entities.Persons;
using System;
using System.Data.Common;

namespace SiteManagementApi.Operation.OperationManager
{
    public class PersonOperation : IPerson
    {
        public PersonGeneralInfo GetByGeneralPersonId(int personId)
        {
            try
            {
                SpCall sp = new SpCall("Get_Persons");
                sp.SetInt("@PersonId", personId);
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public PersonApartment GetByPersonApartment(int personId)
        {
            try
            {
                SpCall sp = new SpCall("Get_PersonApartmentsAll");
                sp.SetInt("@PersonId", personId);
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public PersonCommunication GetByPersonCommunication(Guid personCommId)
        {
            try
            {
                SpCall sp = new SpCall("Get_PersonCommunicationsByCommId");
                sp.SetGuid("@CommId", personCommId);
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public PersonDetail GetByPersonDetail(int personId)
        {
            try
            {
                SpCall sp = new SpCall("Get_PersonDetailById");
                sp.SetInt("@PersonId", personId);
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public Person GetByPersonId(int personId)
        {
            try
            {
                SpCall sp = new SpCall("Get_PersonById");
                sp.SetInt("@PersonId", personId);
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public PersonIdentityInformation GetByPersonIdentityInformation(Guid personIdentId)
        {
            try
            {
                SpCall sp = new SpCall("Get_PersonCommunicationsByCommId");
                sp.SetGuid("@IdentId", personIdentId);
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public PersonVehicle GetByPersonVehicle(int personId)
        {
            try
            {
                PersonVehicle res = null;
                DashboardContext context = new DashboardContext();

                SpCall sp = new SpCall("Get_PersonVehiclesById");
                sp.SetInt("@PersonId", personId);
                DbCommand cmd;
                DbDataReader rdr;

                cmd = context.Database.GetDbConnection().CreateCommand();
                cmd.CommandText = sp.ToString();
                context.Database.OpenConnection();
                rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (rdr.Read())
                {
                    res = new PersonVehicle
                    {
                        Id = (int)rdr["Id"],
                        PersonId = (int)rdr["Id"],
                        Plate = rdr["Plate"].ToString(),
                        Brand = rdr["Brand"].ToString(),
                        Model = rdr["Model"].ToString(),
                        Color = rdr["Color"].ToString(),
                        IsActive = (bool?)rdr["Brand"],
                    };
                }
                rdr.Close();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public WaitingApprovePerson GetByWaitingApprovePerson(int personId)
        {
            throw new NotImplementedException(); // Gerekli mi ??
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
            try
            {
                List<PersonApartment> res = new List<PersonApartment>();
                List<PersonApartment> pList = new List<PersonApartment>();
                PersonApartment person;
                SpCall sp = new SpCall("Get_PersonApartmentsAll");

                using (DashboardContext dashboardContext = new DashboardContext())
                {
                    pList = dashboardContext.PersonApartments.FromSqlRaw(sp.ToString()).ToList();
                    foreach (PersonApartment item in pList)
                    {
                        person = new PersonApartment();
                        person.Description = item.Description;
                        res.Add(person);
                    }
                }
                return res;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public List<PersonCommunication> GetPersonCommunicationsAll()
        {
            try
            {
                SpCall sp = new SpCall("Get_PersonCommunicationsAll");
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public List<PersonDetail> GetPersonDetailAll()
        {
            try
            {
                SpCall sp = new SpCall("Get_PersonDetailAll");
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public List<PersonIdentityInformation> GetPersonIdentityInformationAll()
        {
            try
            {
                SpCall sp = new SpCall("Get_PersonIdentityInformationsAll");
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public List<Person> GetPersonsListAll()
        {
            try
            {
                List<Person> res = new List<Person>();
                DashboardContext context = new DashboardContext();
                SpCall spName = new SpCall("dbo.Get_PersonsAll");

                DbCommand cmd;
                DbDataReader rdr;

                cmd = context.Database.GetDbConnection().CreateCommand();
                cmd.CommandText = spName.ToString();
                context.Database.OpenConnection();
                rdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (rdr.Read())
                {
                    res.Add(new Person
                    {
                        FirstName = rdr["FirstName"].ToString(),
                        LastName = rdr["LastName"].ToString(),
                        PersonType = (int?)rdr["PersonType"]
                        // diğer kolonları unutma !!!!
                    });
                }
                rdr.Close();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public List<PersonVehicle> GetPersonVehicleAll()
        {
            try
            {
                SpCall sp = new SpCall("Get_VehicleAll");
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }
        
        public List<WaitingApprovePerson> GetWaitingApprovePeopleAll()
        {
            try
            {
                SpCall sp = new SpCall("GET_WaitingApprovePersonAll");
            }
            catch (Exception)
            {

                throw;
            }
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

        public int GeneralPersonSave(PersonGeneralInfo personGeneral)
        {
            int res = 0;
            try
            {
                DashboardContext context = new DashboardContext();
                SpCall sp = new SpCall("PreparePerson_Insert");
                sp.SetString("@FirstName", personGeneral.person.FirstName);
                sp.SetString("@LastName", personGeneral.person.LastName);
                sp.SetInt("@PersonType", personGeneral.person.PersonType);

                res = context.Database.ExecuteSqlRaw(sp.ToString());

                return res;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int PersonSave(Person person)
        {
            int res = 0;
            try
            {
                DashboardContext context = new DashboardContext();
                SpCall sp = new SpCall("PreparePerson_Insert");
                sp.SetString("@FirstName", person.FirstName);
                sp.SetString("@LastName",  person.LastName);
                sp.SetInt("@PersonType",   person.PersonType);

                res = context.Database.ExecuteSqlRaw(sp.ToString());

                return res;
            }
            catch (Exception)
            {
                return -1;
            }
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
