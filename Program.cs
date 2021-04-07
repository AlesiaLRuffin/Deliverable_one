using System;

namespace deliverable_one
{
    class Program
    {
        static void Main(string[] args)
        {
            BeginAgain:
                Console.WriteLine("Which unit of measure would you like to " +
                    "convert to (M)ilHip  or to (I)mperial?");
                char measure = Convert.ToChar(Console.ReadLine());

                if (measure == 'I')
                {
                    Console.WriteLine("Are you converting to feet(f) or " +
                        "inches(i)");
                    char unit = Convert.ToChar(Console.ReadLine());
                    if (unit == 'f')
                    {
                        Console.WriteLine("What is the amount memes you have?");
                        decimal amountm = Convert.ToDecimal(Console.ReadLine());
                        decimal convertf = amountm / 5;
                        Console.WriteLine("Your " + amountm + " memes convert to " + convertf + " feet");
                    }

                    else

                    {
                        Console.WriteLine("What amount of fidget spinners do you have?");
                        double amountfs = Convert.ToDouble(Console.ReadLine());
                        double converti = amountfs / 3.5;
                        Console.WriteLine("Your " + amountfs + " fidget spinners converts to " + converti + " inch(s)");
                    }

                }
                else if (measure == 'M')
                {
                    Console.WriteLine("Are you converting fidget spinners(t) or memes(m)");
                    char unit = Convert.ToChar(Console.ReadLine());
                    if (unit == 'm')
                    {
                        Console.WriteLine("How many feet do you need to convert?");
                        decimal amountf = Convert.ToDecimal(Console.ReadLine());
                        decimal convertm = amountf * 5;
                        Console.WriteLine("Your " + amountf + " foot(feet) convert to " + convertm + " memes.");
                    }
                    else
                    {
                        Console.WriteLine("How many inches do you have?");
                        double amounti = Convert.ToDouble(Console.ReadLine());
                        double convertt = amounti * 3.5;
                        Console.WriteLine("Your " + amounti + " inch(s) converts to " + convertt + " fidget spinner(s)");
                    }
                }
                Console.WriteLine("Would you like to do another conversion? Y or N");
                char again = Convert.ToChar(Console.ReadLine());
                if (again == 'Y')
                { goto BeginAgain; }
                else { }
            }
        }
    }
