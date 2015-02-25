using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Programming2_Assignment03
{
    class GiantPlanet : Planet , IHasMoons , IHasRings
    {
        // private instance variables ++++++++++++++++++++++++++++++++++++
        private string _type;

        // constructors
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }

        // public methods +++++++++++++++++++++++++++++++++
        public bool HasMoons()
        {
            if (MoonCount > 0)
            { 
                return true; 
            }
            else
            {
                return false; 
            }
            
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
