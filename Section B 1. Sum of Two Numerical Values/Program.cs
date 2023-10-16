using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_B_1.Sum_of_Two_Numerical_Values
{
    internal class Program
    {
        public static int Sum(int num1, int num2)
        {
            return num1 == num2 ? 3 * (num1 + num2) : num1 + num2;
        }
        static void Main(string[] args)
        {

            int[] input1 = { 1, 3, 2 };
            int[] input2 = { 2, 2, 2 };

            for (int i = 0; i < input1.Length; i++)
            {
                int sum = Sum(input1[i], input2[i]);
                Console.WriteLine($"The sum of {input1[i]} and {input2[i]} is {sum}");

                Console.ReadLine();

            }
    }   }
}
