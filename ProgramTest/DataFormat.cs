using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest
{
    class DataFormat
    {
        public static void GetStudData(int i, double d, char c, bool b, string s, string l)
        {
            Console.WriteLine("------ Student Data ------");
            Console.Write("Name : " + s +
                          "\nRoll Number : " + i +
                          "\nMy Marks : " + d +
                          "\nMy location : " + l + "" +
                          "\nMy Name Letter Start" + c + "" +
                          "\nDid I Pass : " + b
                          );
            Console.WriteLine("\n");
        }


        public static void GetNumbersData(int i, long l, float f, double d, bool t, bool fa)
        {
            Console.WriteLine("------DataTypes ------");
            Console.Write("Integer Value : " + i + "\nLong Value : " + l + "\nFloat Value : " + f + "\nDouble Value : " + d + "\nBoolean value : " + t + "\nBoolean Value : " + fa);
            Console.WriteLine("\n");

        }
        public static void ConvertData(int i, double d, bool b, string s)
        {
            Console.WriteLine("------ Conversing Data ------");
            Console.WriteLine("String Value :" + Convert.ToString(i));    // convert int to string
            Console.WriteLine("Double Value :" + Convert.ToDouble(i));    // convert int to double
            Console.WriteLine("Integer Value :" + Convert.ToInt32(d));  // convert double to int
            Console.WriteLine("Long Value :" + Convert.ToInt64(d));  // convert double to long
            Console.WriteLine("String Value :" + Convert.ToString(b));   // convert bool to string
            Console.WriteLine("Boolean Value :" + Convert.ToBoolean(s));   // convert string to bool
            Console.WriteLine("\n");

        }

        public static void GetFullName(string fName, string lName)
        {
            Console.WriteLine("------Full Name Using Concat and Interpolation ------");
            //character or string to conacatinate a variable to another variable
            string fullName = string.Concat(fName, lName);
            Console.WriteLine("Full Name : " + fullName);

            //String Interpolation
            string name = $"My full name is: {fName} {lName}";
            Console.WriteLine("Full Name : " + name);
            Console.WriteLine("\n");
        }

        public static void GetFullName(string fName, int uAge)
        {
            Console.WriteLine("------ UserName With Age ------");
            // Print the value of the variable which will display the input value
            Console.WriteLine("Username is: " + fName + " \nAge is: " + uAge);
            Console.WriteLine("\n");
        }
        public static int AddNumbers(int x, int y, int z)
        {
            return x + y + z;
        }
        public static int AddNumbers(int x, int y)
        {
            return x + y;
        }
        public static void MathOperator()
        {
            Console.WriteLine("------ Math Operators like min, max etc ------");
            Console.Write("Maximum Value : " + Math.Max(5, 10));
            Console.Write("\nMinimum Value : " + Math.Min(5, 10));
            Console.Write("\nSquare Root Value : " + Math.Sqrt(64));
            Console.Write("\nAbsolute Value : " + Math.Abs(-4.7));
            Console.Write("\nRound Value : " + Math.Round(9.99));
            Console.Write("\n");
        }

        public static void ArraySorting(string[] str, int[] arr)
        {
            Console.WriteLine("------ Sorting Data ------");
            // Sort the arr from last to first.
            // compare every element to each other
            Array.Sort<string>(str, new Comparison<string>((i1, i2) => i2.CompareTo(i1)));

            Console.WriteLine("Descending the string array : ");
            // print all element of array
            foreach (string value in str)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");

            // Sort array in ascending order.
            Array.Sort(arr);

            // print all element of array
            Console.Write("Ascending Order : ");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");

            // reverse array
            Array.Reverse(arr);
            Console.Write("Descending Order : ");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");


            // compare every element to each other
            Array.Sort<int>(arr, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

            // print all element of array
            Console.Write("descending order using comparision : ");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");
        }

        public static void GetArrayMath(int[] myNumbers)
            {
                Console.Write("Printing the array for min,max and sum : ");
                //Finding the min max and sum
                foreach (int value in myNumbers)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Maximum Number in the array : " + myNumbers.Max());  // returns the largest value
                Console.WriteLine("Minimum Number in the array : " + myNumbers.Min());  // returns the smallest value
                Console.WriteLine("Sum Of Number in the array : " + myNumbers.Sum());  // returns the sum of elements
                Console.ReadLine();
            

        }
    }
}
