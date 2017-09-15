using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverablenumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userEnterCorrectValues = false;
            string string1 = "";
            string string2 = "";

            while (userEnterCorrectValues == false)
                
              // The use of the while statement will evaluate the user's input
            {
                Console.WriteLine("Please enter the value for the first number:");
                string1 = Console.ReadLine();
                Console.WriteLine("Please enter the value for your second number:");
                string2 = Console.ReadLine();

                if (string1.Count()==string2.Count())
                {
                    userEnterCorrectValues = true;
                }
                else
                {
                    Console.WriteLine("Please re-enter the values");
                }
            }

            bool result = ProblemSolver(string1, string2);

            Console.WriteLine("The problem evaluates to " + result.ToString());

        }
        public static bool ProblemSolver(string num1, string num2)

        {
            bool check = true;
            int firstSum = 0;
            for (int i = 0; i < num1.Count (); i++ )
            {
                if (i == 0)
                {
                    firstSum = Int32.Parse(num1[i].ToString()) + Int32.Parse(num2[i].ToString());
                }

                if ((Int32.Parse(num1[i].ToString()) + Int32.Parse(num2[i].ToString())) != firstSum)
                {
                    check = false;
                }
            }
            return check;
        }
    }
}
