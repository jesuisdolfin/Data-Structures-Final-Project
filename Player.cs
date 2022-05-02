using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructuresFinalGUI
{
    public class Player
    {
        // properties
        public string name;
        public string position;
        public int rating;

        // constructor
        public Player(string name, string position, int rating)
        {
            this.name = name;
            this.position = position;
            this.rating = rating;
        }
    }
}
