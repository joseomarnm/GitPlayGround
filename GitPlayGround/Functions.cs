using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPlayGround
{
    class Functions
    {
        public static int Sum(int a, int b) {
            return a + b;
        }

        public static int Substract(int a, int b) {
            return a - b;
        }

        public static int Multiply(int a, int b) {
            return a * b;
        }

        public static int Divide(int a, int b) {
            return a / b;
        }
        
        public static double Power(int a, int b) {
            return Math.Pow(a, b);
        }
    }
}
