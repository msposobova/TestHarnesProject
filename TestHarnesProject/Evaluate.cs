using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestHarnesProject
{
    public class Evaluate
    {
        public static int EvaluateGCD( int a, int b)
        {
            if (a == 0 || b== 0)
            {
                throw new Exception("One of the numbers equals 0!");
            }

            else
            {
                while (a != 0 && b != 0)
                {
                    if (a > b)
                        a %= b;
                    else
                        b %= a;
                }
            }

            return a | b;
        }

        public static int EvaluateMaxMin (int a, int b)
        {
            if (a == b)
            {
                throw new Exception("Not able to display MAX or MIN VALUE. The numbers are equal!");
            }

            else if (a < b)
            {
                return b;
            }
            else
            {
                return a;

            }
        }

        public static double EvaluateAvg(double a, double b)
        {
            if (a == b)
            {
                throw new Exception("The average value is the same when the numbers are equal!");
            }

            else
            {
                return (a + b)/2;
            }
        }

        public static string EvaluateCharNum (int a)
        {
            if (a < 33 || a > 255)
            {
                throw new Exception("There is no  Char value for the numbers less than 33 or more than 255!");
            }

            else
            {
                return Convert.ToString((char)a);
            }
        }
    }
}
