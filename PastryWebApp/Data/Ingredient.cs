using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryWebApp.Data
{
    public class Ingredient : IObjectState
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Quantity { get; set; }
        public string MeasureUnit { get; set; }
        public ObjectStates State { get; set; }
    }
}
