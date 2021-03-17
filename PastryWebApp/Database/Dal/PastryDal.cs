using PastryWebApp.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryWebApp.Database.Dal
{
    public class PastryDal : IDisposable
    {
        private PastryDbContext _ctx;

        public PastryDal(PastryDbContext ctx)
        {
            _ctx = ctx;            
        }

        public List<Pastry> GetAll()
        {
            var pastries = _ctx.Pastries.ToList();
            return pastries;
        }

        public Pastry GetPastryById(int id)
        {
            var pastry = _ctx.Pastries.Where(p=>p.Id == id).FirstOrDefault();
            return pastry;
        }

        public int Add(Pastry pastry)
        {
            _ctx.Pastries.Add(pastry);
            _ctx.SaveChanges();
            return pastry.Id;
        }

        public void Update(Pastry pastry)
        {
            var item = _ctx.Pastries.Where(p => p.Id == pastry.Id).FirstOrDefault();
            if (item != null)
            {
                item.Name = pastry.Name;
                item.ProductionDate = pastry.ProductionDate;
                item.Ingredients = pastry.Ingredients;
                _ctx.SaveChanges();
            }
        }

        public void Delete(Pastry pastry)
        {
            _ctx.Pastries.Remove(pastry);
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
