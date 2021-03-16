using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PastryWebApp.Database;
using PastryWebApp.Database.Dal;
using PastryWebApp.Database.Entities;
using System;

namespace PastryWebAppTest
{
    [TestClass]
    public class DalTest
    {
        string _connectrionString = "Data Source=C:\\Users\\lucav\\Documents\\Personale\\PastryWebAppDb.db";
        
        
        PastryDbContext GetContext()
        {
            var options = new DbContextOptionsBuilder<PastryDbContext>()
                .UseSqlite(_connectrionString)
                .Options;
            return new PastryDbContext(options);
        }


        [TestMethod]
        public void PastryAdd()
        {
            var ctx = GetContext();
            var pastry = new Pastry { Name = "Pasticceria", ProductionDate = DateTime.Now };
            PastryDal dal = new PastryDal(ctx);
            dal.Add(pastry);
            ctx.Dispose();
        }
    }
}
