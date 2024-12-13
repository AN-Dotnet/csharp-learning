using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.classes
{
    public class SavingsAccount
    {
        public static double currentInterestRate;
        public static double bondRate;
        static SavingsAccount()
        {
            currentInterestRate = 0.4;
        }
        public static void AddBondRate() {
            currentInterestRate = bondRate + 0.1; 
            // static members cannot make any operations involving non static members
            // if we dont define bondRate as static then it will not be allowed to use inside this method bcoz the method is set to static.
        }
    }
}