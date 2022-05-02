using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresFinalGUI
{
    public class IllegalPositionException : Exception
    {
        public override string Message
        {
            get
            {
                return "Please enter either 'C', 'F', or 'G' as a position.";
            }
        }
    }
}
