 namespace Chinook.Core.Models
 {
	public class InvoiceItem
	{
		public long InvoiceLineItemId { get; set; }
		public long InvoiceId { get; set; }
		public long TrackId { get; set; }
		public decimal UnitPrice { get; set; }
		public long Quantity { get; set; }
	}
}