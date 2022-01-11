using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest
{

    /// <summary>
    /// Testing for Different DataTypes
    ///   <br />
    /// </summary>
    public class Program
    {
      
        //Main defines the entry point of the program
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter The Choices from below\n");
                Console.Write("1: Printing Message \n2: Print Student Data \n3: Print Full Name and Age \n4: Number Format\n5: Data Conversion\n6: Math Operations \n7: Generating Random Number\n8: Array Sorting and Math Operations\n9: Addition of Number\n10:Monthly Employee Wage \n11: Exit Program\n");
                int switchOptions = int.Parse(Console.ReadLine());
                switch (switchOptions)
                {
                    case 1:
                        //This message will displays in the console
                        Console.WriteLine("Hello World!");  //This is a statement
                        Console.WriteLine("I will print on a new line.");
                        Console.Write("Hello World! ");
                        Console.Write("I will print on the same line.");
                        Console.Write("\n" + "\n");
                        Console.Write("Enter The Message : ");
                        string Message = Console.ReadLine();
                        Console.Write("The Message is : " + Message);
                        Console.Write("\n" + "\n");

                        break;
                    case 2:
                        //User Data to store in method
                        const string location = "Mumbai";
                        DataFormat.GetStudData(44, 73.64D, 'R', true, "Raj Verma", location);
                        break;
                    case 3:
                        //String method to store string and concat
                        DataFormat.GetFullName("Raj", "Verma");
                        //Taking input from the user
                        Console.Write("Enter username : "); // Type your username and press enter
                        string userName = Console.ReadLine();   // Create a  variable and get user input from the keyboard and store it in the variable
                        Console.Write("Enter your age: ");
                        int myAge = Convert.ToInt32(Console.ReadLine());  //console.readline returns a string
                        DataFormat.GetFullName(userName, myAge);
                        break;
                    case 4:
                        //The int long float bool and double data type
                        DataFormat.GetNumbersData(100000, 1500000000L, 35e3F, 12E4D, true, false);
                        Console.Write("\n");
                        break;
                    case 5:
                        //Type Conversion Methods
                        DataFormat.ConvertData(10, 5.25, true, "false");
                        break;
                    case 6:
                        //Math Operator
                        DataFormat.MathOperator();
                        break;
                    case 7:
                        //Generating a random number
                        Console.Write("Enter The Range In Which You Want Random Numbers : ");
                        int ranNum = int.Parse(Console.ReadLine());
                        Random random = new Random();
                        Console.WriteLine(random.Next(ranNum + 1));
                        break;
                    case 8:
                        // declaring and initializing the string array
                        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
                        int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };
                        int[] myNumbers = { 5, 1, 8, 9 };
                        DataFormat.ArraySorting(cars, arr);
                        DataFormat.GetArrayMath(myNumbers);
                        break;
                    case 9:
                        //Adding numbers
                        Console.Write("How many numbers you want to add : ");
                        Console.WriteLine("1 : Three Numbers , 2 : Two Numbers");
                        int numToAdd = int.Parse(Console.ReadLine());
                        switch (numToAdd)
                        {
                            case 1:
                                Console.Write("Enter the first number : ");
                                int x = int.Parse(Console.ReadLine());
                                Console.Write("Enter the second number : ");
                                int y = int.Parse(Console.ReadLine());
                                Console.Write("Enter the third number : ");
                                int z = int.Parse(Console.ReadLine());
                                Console.Write("Addition Of Three Numbers Is : " + DataFormat.AddNumbers(x, y, z));
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Enter the first number : ");
                                int x1 = int.Parse(Console.ReadLine());
                                Console.Write("Enter the second number : ");
                                int y2 = int.Parse(Console.ReadLine());
                                Console.Write("Addition Of Two Numbers Is : " + DataFormat.AddNumbers(x1, y2));
                                Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Enter The choice between 2 and 3");
                                break;

                        }
                        break;
                    case 10:
                        EmployeeWageComputation.MEmpWageForMulComp();
                        break;
                    case 11:
                        Environment.Exit(0);
                        return;


                }
            }
            

        }
    }
}
