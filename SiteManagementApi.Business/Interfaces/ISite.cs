using SiteManagementApi.Entities.Entities.General;
using SiteManagementApi.Entities.Entities.Site;

namespace SiteManagementApi.Business.Interfaces
{
    public interface ISite
    {
        List<Site> GetGeneralsiteAll();
        Site GetByGeneralSiteId(int Id);
        string SiteGeneralSave(SiteGeneralInfo siteGeneralInfo);
        string SiteGeneralUpdate(SiteGeneralInfo siteGeneralInfo);
        string SiteGeneralDelete(int Id);


        List<Site> GetsiteAll();
        Site GetBySiteId(int Id);
        string SiteSave(Site site);
        string SiteUpdate(Site site);
        string SiteDelete(int Id);


        List<Apartment> GetApartmentAll();
        Apartment GetByApartmentId(int ApartmentId);
        string ApartmentSave(Apartment apartment);
        string ApartmentUpdate(Apartment apartment);
        string ApartmentDelete(int ApartmentId);


        List<Employee> GetEmployeesAll();
        Employee GetByEmployeeId(int EmployeeId);
        string EmployeeSave(Employee employee);
        string EmployeeUpdate(Employee employee);
        string EmployeeDelete(int EmployeeId);


        List<EmployeeBankInfo> GetEmployeeBankInfoAll();
        EmployeeBankInfo GetByEmployeeBankInfoId(int EmployeeId);
        string EmployeeBankInfoSave(EmployeeBankInfo employeeBankInfo);
        string EmployeeBankInfoUpdate(EmployeeBankInfo employeeBankInfo);
        string EmployeeBankInfo(int EmployeeId);

        List<JobToDo> GetJobToDoAll();
        JobToDo GetByJobToDoId(int JobId);
        string JobToDoSave(JobToDo jobToDo);
        string JobToDoUpdate(JobToDo jobToDo);
        string JobToDoDelete(int JobId);

        List<Meeting> GetMeetingAll();
        Meeting GetByMeetingId(int Id);
        string MeetingSave(Meeting meeting);
        string MeetingUpdate(Meeting meeting);
        string MeetingDelete(int Id);


        List<MeetingAttendence> GetMeetingAttendenceAll();
        MeetingAttendence GetByMeetingAttendenceID(int AttendenceId);
        string MeetingAttendenceSave(MeetingAttendence meetingAttendence);
        string MeetingAttendenceUpdate(MeetingAttendence meetingAttendence);
        string MeetingAttendenceDElete(int AttendenceId);




    }
}
