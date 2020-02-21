using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Program
    {
		//input for menu
		public int menuInput;
		static void Main(string[] args)
        {
			//Menu
			bool correctInputMenu = false;
			while (true)
			{
				try
				{
					do
					{
						Console.WriteLine("Menu");
						Console.WriteLine("*****");
						Console.WriteLine("Please select from below Menu");
						Console.WriteLine("1: Enter triangle dimension");
						Console.WriteLine("2: Exit");

						int menuInput = Convert.ToInt32(Console.ReadLine());

						if (menuInput == 1)
						{
							//input for triangle from user
							bool correctInput = false;
							while (true)
							{
								try
								{
									do
									{
										Console.WriteLine("Enter the sides of the triangle:");
										Console.WriteLine("********************************");

										Console.WriteLine("Enter the first side of triangle:");
										int a = Convert.ToInt32(Console.ReadLine());
										Console.WriteLine("Enter the second side of triangle:");
										int b = Convert.ToInt32(Console.ReadLine());
										Console.WriteLine("Enter the third side of triangle:");
										int c = Convert.ToInt32(Console.ReadLine());

										String value = TriangleSolver.Analyze(a, b, c);

										Console.WriteLine(value);
										correctInput = true;
									}
									while (correctInput == false);
									break;
								}
								catch (Exception e)
								{
									Console.WriteLine("Invalid input, please enter the number as input");
									continue;
								}
							}
						}	
						else if (menuInput == 2)
						{
							Environment.Exit(0);
						}
						else
						{
							Console.WriteLine("Please choose the option from menu");
						}
					}
					while (correctInputMenu == false);
					break;
				}
				catch (Exception e)
				{
					Console.WriteLine("Invalid input, Please select the correct menu option from available list of Menu");
					continue;
				}
			}
		}
	}
}
