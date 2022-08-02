using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoritePlants
{
    class Shrub : Plant
    {
        //will display a message if the user selects the shrub type and selects the sniff button.
        public override string Sniff()
        {
            return "Smells like shrubbery. Some knights might need this.";
        }

    }
}
