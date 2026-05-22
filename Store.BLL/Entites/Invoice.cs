using Store.BLL.Entites;

namespace Store.BLL.Entities
{
    public class Invoice
    {
        public User Author { get; set; }
        public List<InvoiceItem> Items { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
