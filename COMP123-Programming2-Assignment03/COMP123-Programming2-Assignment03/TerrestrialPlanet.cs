using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Programming2_Assignment03
{
    class TerrestrialPlanet : Planet , IHasMoons, IHabitable
    {
        // private instance variables +++++++++++++++++++++++++++++++++++++++++++++++++++
        private bool _oxygen;

        // constructors++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // Interface methods ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public bool HasMoons()
        {
            return (MoonCount > 0) ? true : false;  

        }

        public bool Habitable()
        {
            return (this._oxygen == true) ? true : false;  
        }
    }
}
