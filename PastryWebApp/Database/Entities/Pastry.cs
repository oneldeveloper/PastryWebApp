using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PastryWebApp.Database.Entities
{
    public class Pastry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ProductionDate { get; set; }

        public int Quantity { get; set; }

        public virtual List<Ingredient> Ingredients { get; set; }

    }
}
