using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PastryWebApp.Data
{
    public enum ObjectStates { Added, Removed, Edited}
    public interface IObjectState
    {
        ObjectStates State { get; set; }
    }
}
