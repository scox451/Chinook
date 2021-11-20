using System.Collections.Generic;
using System.Linq;
using Chinook.Core;
using Chinook.Core.Models;

namespace Chinook.Core.Repos
{
    public class BaseRepo
    {
        
        internal ChinookContext Context()
         {
            
                 string[] NoArgs = new string[0];

                 return new DbFactory().CreateDbContext(NoArgs);
            
        }

    }
}