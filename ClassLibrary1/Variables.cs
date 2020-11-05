using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary1
{
    public class Variables
    {   

        public static int SolveTask1(int a, int b)
        {

            int x = (5 * a + b * b) / (b - a);
            return x;
        }
        public static int SwapAToB(int a, int b)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int x = a;
            a = b;
            b = x;
            return x;
        }
        public static int ReusltDivision(int a, int b)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int x = a / b;
           
            return x;

        }
        public static int ReusltRemander(int a, int b)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int y = a % b;
            return y;

        }
        public static int DerivateEquationOfStraightLine(int x1, int x2, int y1, int y2)
        {
                      
            int y;
            int x;
            //y = a*x + b;
            int a = (y2 - y1) / (x2 - x1);
            int b = -(x1 * y2 - x2 * y1) / (x2 - x1);
            y = a * x + b;
            return y;
        }

        public static int [] DASKL (int a)
        {
            int []arr = new int 
        }


    }
}
