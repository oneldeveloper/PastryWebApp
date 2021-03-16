using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryWebApp.Database
{
    public static class PastryDbUtils
    {


        public static void Create(PastryDbContext context)
        {
           //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

        }

        public static void Initialize(PastryDbContext context)
        {

        }
    }
}
