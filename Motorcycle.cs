using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._06._20HW
{
    class Motorcycle : Vehicle
    {

        public int _NumberOfHandBreaks;





        public override int GetMaxNumOfPassenger()
        {
            return 2;
        }

        public override int GetMaxSpeed()
        {
            return 300;
                
        }

        public override string ToString()
        {
            return $"[Motorcycle]: NumberOfHandBreaks: {_NumberOfHandBreaks} {base.ToString()}";
        }
    }
}
