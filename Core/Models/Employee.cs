using System;

 namespace Chinook.Core.Models
 {
	public class Employee
	{
		public long EmployeeId { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string Title { get; set; }
		public long ReportsTo { get; set; }
		public DateTime BirthDate { get; set; }
		public DateTime HireDate { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public string PostalCode { get; set; }
		public string Phone { get; set; }
		public string Fax { get; set; }
		public string Email { get; set; }
	}
}