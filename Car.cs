using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._06._20HW
{
    class Car : Vehicle
    {

        public int _NumberOfDoors;


        public override int GetMaxNumOfPassenger()
        {
            return 5;
        }

        public override int GetMaxSpeed()
        {
            return 220;
        }

        public override string ToString()
        {
            return $"[Car]:NumberOfDoors{_NumberOfDoors} {base.ToString()}"; 
        }
    }
}
