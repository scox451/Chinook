

using Chinook.Core.Data;

namespace Chinook.Core.Repository
{
    class RCustomer
    {
        private readonly AppDbContext db;

        public RCustomer(AppDbContext context)
        {
            db = context;
        }

        // public int InsertPerson(tbl_Person person)
        // {
        //     try
        //     {
        //         db.tbl_Person.Add(person);
        //         db.SaveChanges();
        //         return person.PersonID;
        //     }
        //     catch
        //     {
        //         return 0;
        //     }
        // }
    }
}