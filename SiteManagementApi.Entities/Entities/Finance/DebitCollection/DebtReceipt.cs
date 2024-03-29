namespace SiteManagementApi.Entities.Entities.Finance.DebitCollection
{
    public class DebtReceipt
    {
        public int Id { get; set; }
        // borçlu. person tablosundaki id ile eşleşir
        public int DebtorId { get; set; }
        // Daire id
        public Guid? ApartmentId { get; set; }
        // Kategori id. parametrik
        public string? CategoryId { get; set; }
        // borç tarihi
        public DateTime DebtDate { get; set; }
        // son ödeme tarihi
        public DateTime PaymentDueDate { get; set; }
        // borç satırları idsi
        public Guid? DebtRow { get; set; }
        // makbuz tipi
        public int ReceiptType { get; set; }
        public string? DebtDescription { get; set; }
        // Aktif mi?
        public int? IsActive { get; set; }
        // Oluşturan kullanıcı adı
        public string? CreatedUserName { get; set; }
        // Oluşturulan tarih
        public DateTime? CreatedDate { get; set; }
        // Son güncelleyen kullanıcı
        public string? UpdatedUserName { get; set; }
        // Son güncelleme tarihi
        public DateTime? UpdatedDate { get; set; }
    }
    public class Deb
}
