using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp.classes
{
    public class DelegateExample
    {
        public delegate int MathOperation(int x, int y);

        public static int Add(int x, int y) => x + y;
        public static int Multiply(int x, int y) => x * y;

        public static void main() {
            MathOperation operation = Add;
            Console.WriteLine(operation(5,5)); // output 10

            operation = Multiply;
            Console.WriteLine(operation(5,5)); // output 25
        }
    }
}