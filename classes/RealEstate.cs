using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpLearning.classes
{
    public class RealEstate
    {
        public string Address { get; set; }
        public int Price { get; set; }
        public int SquareFootage { get; set; }
        public int CalculatePricePerSquareFoot() => Price / SquareFootage;
        public (int a, string b, bool c) ReturnValuesWithTupleReturnType () => (9, "Arjun", true);
    }
}