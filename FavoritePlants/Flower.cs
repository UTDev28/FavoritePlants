using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoritePlants
{
    class Flower : Plant
    {
        //when the type is flower, and the user selects sniff, it will display the message.
        public override string Sniff()
        {
            return "Smells like bonbon.";
        }

        //When the type is flower, this message will display in the details
        public override string Pick()
        {
            return "Why do roses have thorns?";
        }

        //constructor
        public Flower()
        {
           Name = "Default FLOWER name";
            Enviroment = "Default FLOWER enviroment";
        }

        public Flower(string name, string environment)
        {
            Name = name + "!";
            Enviroment = environment + "!";
        }


    }
}
