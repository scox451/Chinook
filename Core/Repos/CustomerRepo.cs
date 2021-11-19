using System.Collections.Generic;
using System.Linq;
using Chinook.Core.Models;

namespace Chinook.Core.Repos
{
    public class CustomerRepo : BaseRepo
    {
        public IEnumerable<Customer> GetCusomers()
        {
            using (var context = Context())
            {
                var result = context.Customers.ToList();
                return result;
            }
        }

        public long Insert(Customer customer)
        {

            try
            {
                using (var context = Context())
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                    return customer.CustomerId;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}