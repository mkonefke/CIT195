using System;
using System.Linq.Expressions;

namespace tempConverter
{
    class temps
    {
        public static void Main(string[] args)
        {
            int intNumToConvert;
            double dblNumToConvert;
            bool stop = false;
            do
            {
                try
                {
                    intNumToConvert = 0;
                    dblNumToConvert = 0;

                    Console.WriteLine("Enter the temp you want converted");
                    var numberToConvert = Console.ReadLine();
                    while (!double.TryParse(numberToConvert, out dblNumToConvert) && !int.TryParse(numberToConvert, out intNumToConvert))
                    {
                        Console.WriteLine("You must enter a valid number, please try again");
                        numberToConvert = Console.ReadLine();
                    }
                    if (intNumToConvert > 0)
                    {
                        convertTemp(intNumToConvert);
                    }
                    else
                    {
                        convertTemp(dblNumToConvert);
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You need to enter a number");
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("The number you entered is too big");
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred, please try again.");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Do you want to convert another temp? (Y for yes, any key for no)");
                    char more;
                    while(!char.TryParse(Console.ReadLine(), out more))
                    {
                        Console.WriteLine("Please enter a valid character, try again...");
                    }
                    if (Char.ToLower(more) != 'y')
                        stop = true;
                }
            } while (!stop);

        }
		private static void convertTemp(int intNumToConvert)
        {
            int fahrenheit = 0;
            int celsius = 0;
            try
            {
                fahrenheit = (intNumToConvert * 9 / 5) + 32;
                celsius = (intNumToConvert - 32) * 5 / 9;
            }
                catch (ArithmeticException t)
                {
                    Console.WriteLine("Temperature could not be converted");
                    Console.WriteLine(t.Message);
                }
                catch (Exception t)
                {
                    Console.WriteLine("An error occurred, please try again.");
                    Console.WriteLine(t.Message);
                }
                finally
                {
                    if(fahrenheit == 0 || celsius == 0)
                    {
                        Console.WriteLine("Temp couldn't be converted");
                    }
                    else
                    {
                        Console.WriteLine($"{intNumToConvert} degrees Celsius converted to Farhrenheit is {fahrenheit}");
                        Console.WriteLine($"{intNumToConvert} degrees Celsius converted to Farhrenheit is {fahrenheit}");
                    }
                }
              return;
        }
        private static void convertTemp(double intNumToConvert)
        {
            double fahrenheit = 0;
            double celsius = 0;
            try
            {
                fahrenheit = (intNumToConvert * 9 / 5) + 32;
                celsius = (intNumToConvert - 32) * 5 / 9;
            }
                catch (ArithmeticException t)
                {
                    Console.WriteLine("Temperature could not be converted");
                    Console.WriteLine(t.Message);
                }
                catch (Exception t)
                {
                    Console.WriteLine("An error occurred, please try again.");
                    Console.WriteLine(t.Message);
                }
                finally
                {
                    if(fahrenheit == 0 || celsius == 0)
                    {
                        Console.WriteLine("Temp couldn't be converted");
                    }
                    else
                    {
                        Console.WriteLine($"{intNumToConvert} degrees Celsius converted to Farhrenheit is {fahrenheit}");
                        Console.WriteLine($"{intNumToConvert} degrees Celsius converted to Farhrenheit is {fahrenheit}");
                    }
                }
            return;
        }

    }
}