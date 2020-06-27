using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._06._20HW
{
    abstract class Vehicle
    {
        public int _NumberOfWheels;
        public string _Model;


        public abstract int GetMaxNumOfPassenger();
        public abstract int GetMaxSpeed();

        public override string ToString()
        {
            return $"[Vehicle]: NumberOfWheels : {_NumberOfWheels} , Model :{_Model} MaxNumOfPassenger: {GetMaxNumOfPassenger()} MaxSpeed: {GetMaxSpeed()} ";
        }
    }
}
