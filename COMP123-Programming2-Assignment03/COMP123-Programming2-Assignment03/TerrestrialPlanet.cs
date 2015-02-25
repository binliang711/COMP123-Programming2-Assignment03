using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Programming2_Assignment03
{
    class TerrestrialPlanet : Planet , IHasMoons, IHabitable
    {
        // private instance variables ++++++++++++++++++++++++++++++++++++
        private bool _oxygen;

        // constructors
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
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

        // public methods +++++++++++++++++++++++++++++++++
        public bool Habitable()
        {
            if ( _oxygen == true)
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
