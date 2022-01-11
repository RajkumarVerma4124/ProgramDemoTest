using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest
{
    internal class Calculator
    {
		public static int num1;
		public static int num2;


		public static int getAdd()
		{
			return num1 + num2;
		}
		public static int getSub()
		{
			return num1 - num2;
		}
		public static int getMul()
		{
			return num1 * num2;
		}
		public static int getMul(int num1, int num2)
		{
			return num1 * num2;
		}
		public static double getDiv()
		{
			return (double)num1 / num2;
		}
	}
}
