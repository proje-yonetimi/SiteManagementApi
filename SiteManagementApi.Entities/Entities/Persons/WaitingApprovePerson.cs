namespace SiteManagementApi.Entities.Entities.Persons
{
    public class WaitingApprovePerson
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        // Onay durumu parametre tablosundan çekilir.
        public int Status { get; set; }
        public string? CreatedUserName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
