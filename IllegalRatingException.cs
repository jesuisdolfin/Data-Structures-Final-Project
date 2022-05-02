using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresFinalGUI
{
    class IllegalRatingException : Exception
    {
        public override string Message
        {
            get
            {
                return "Please only enter integers for the player rating.";
            }
        }
    }
}
