using PastryWebApp.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryWebApp.Database.Dal
{
    public class IngredientsDal : IDisposable
    {
        private PastryDbContext _ctx;

        public IngredientsDal(PastryDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Ingredient> GetAll()
        {
            var ingredients = _ctx.Ingredients.ToList();
            return ingredients;
        }

        public List<Ingredient> GetIngredientsByPastry(int pastryId)
        {
            var ingredients = _ctx.Ingredients.Where(p => p.PastryId == pastryId).ToList();
            return ingredients;
        }

        public int Add(Ingredient ingredient)
        {
            _ctx.Ingredients.Add(ingredient);
            _ctx.SaveChanges();
            return ingredient.Id;
        }

        public void Update(Ingredient ingredient)
        {
            var item = _ctx.Ingredients.Where(p => p.Id == ingredient.Id).FirstOrDefault();
            if (item != null)
            {
                item.Name = ingredient.Name;
                item.PastryId = ingredient.PastryId;
                item.Quantity = ingredient.Quantity;
                item.MeasureUnit = ingredient.MeasureUnit;
                _ctx.SaveChanges();
            }
        }

        public void Delete(Ingredient ingredient)
        {
            _ctx.Ingredients.Remove(ingredient);
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
