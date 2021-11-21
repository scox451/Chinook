export class Invoice
{
	public invoiceId: number;
	public customerId: number;
	public invoiceDate: Date;
	public billingAddress: string;
	public billingCity: string;
	public billingState: string;
	public billingCountry: string;
	public billingPostalCode: string;
	public total: number;
}