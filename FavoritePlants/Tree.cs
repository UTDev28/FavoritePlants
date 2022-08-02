using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoritePlants
{
    class Tree : Plant
    {
        public override string Sniff()
        {
            return "Why am I sniffing a tree?";
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Chop()
        {
            return "Punching a tree only works in video games.";
        }

        //This will trigger the plant class constructor with parameters
        //by using the base keyword
        public Tree(string name, string enviroment, int age) : base(name, enviroment)
        {
            Age = age;
        } 
     
    }
}
