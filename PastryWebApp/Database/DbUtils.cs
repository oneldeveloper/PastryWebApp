using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryWebApp.Database
{
    public static class DbUtils
    {


        public static void Create(DbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        public static int Initialize<TEntity>(DbContext context, TEntity entity) where TEntity : class, IEntity
        {
            var dbset = context.Set<TEntity>();
            dbset.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }
    }
}
