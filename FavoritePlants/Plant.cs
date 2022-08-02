using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoritePlants
{
    public abstract class Plant 
    {

        private string _name;
        private string _environment;

        //get = read only property
        //set = write only property
        //most of the time you want read/write
        public string Enviroment
        {
            get { return _environment; }
            set { _environment = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //constructors
        public Plant()
        {

            Name = "Default PLANT name";
            Enviroment = "Defualt PLANT enviroment";
        }

        public Plant(string name, string enviroment)
        {
            Name = name;
            Enviroment = enviroment;
        }

        //abstract methods

        public abstract string Sniff();
        public virtual string Pick()
        {
            return "Default PLANT pick";
        }
    }
}
