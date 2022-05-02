using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalGUI
{
    public class IllegalNameException : Exception
    {
        public override string Message
        {
            get
            {
                return "Do not enter integers as a player name.";
            }
        }
    }
}
