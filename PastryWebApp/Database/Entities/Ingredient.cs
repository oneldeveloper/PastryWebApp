using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PastryWebApp.Database.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        public int PastryId { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string MeasureUnit { get; set; }

        public virtual Pastry Pastry {get; set;}
    }
}
