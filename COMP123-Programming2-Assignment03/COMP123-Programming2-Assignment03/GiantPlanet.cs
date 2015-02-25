using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Programming2_Assignment03
{
    class GiantPlanet : Planet , IHasMoons , IHasRings
    {
        // private instance variables ++++++++++++++++++++++++++++++++++++++++++++++++
        private string _type;

        // constructors+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }

        // Interface methods +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public bool HasMoons()
        {
            return (MoonCount > 0) ? true : false;  
        }

        public bool HasRings()
        {
            return (RingCount > 0) ? true : false;  
        }
    }
}
