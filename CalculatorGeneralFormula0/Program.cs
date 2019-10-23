using System;

namespace CalculatorGeneralFormula0
{
    class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "I just wanna write me some damn stings to my damn console.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "This really doesn't need to be this complex with locales and crap.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1304:Specify CultureInfo", Justification = "Just the same locale issue as above.")]
        static void Main()
        {
            double a = 0, b = 0, c = 0, xAdd, xSub;

            try
            {
                //Inputs
                Console.WriteLine("This program will calculate the two outputs of the general/quadratic formula.");
                Console.WriteLine("Make sure your equation is in the correct form.");
                Console.WriteLine("The form is ax^2 + bx + c = 0");
                Console.WriteLine();
                Console.WriteLine("Input a:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input b:");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input c:");
                c = Convert.ToDouble(Console.ReadLine());
            }

            catch (System.FormatException)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine();
                Console.WriteLine();
                Main();
            }

            //Input Checks
            if (a == 0)
            {
                MathError("Divided by Zero. Check if \"a\" is equal to 0.");
            }
            if (Math.Pow(b, 2) < 4 * a * c)
            {
                MathError("Negative square root. Check \"a\", \"b\", and \"c\".");
            }

            //Addition Formula Math
            xAdd = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            
            //Subtraction Formula Math
            xSub = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            //Outputs
            if (xAdd == xSub)
            {
                Console.WriteLine();
                Console.WriteLine("There is only one solution.");
                Console.WriteLine();
                Console.WriteLine("x = " + xAdd);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("There are two solutions.");
                Console.WriteLine("The first result is for addition. The second result is for subtraction.");
                Console.WriteLine();
                Console.WriteLine("x1 = " + xAdd);
                Console.WriteLine("x2 = " + xSub);
            }

            Restart();

        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "Same locale issue.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1304:Specify CultureInfo", Justification = "Same as above.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "My IDE is stringphobic.")]
        
        //Method for Math Errors. Takes error message as a string input and gives the user the choice to restart the program.
        private static void MathError(string mathErrorMessage)
        {
            Console.WriteLine("Math Error");
            Console.WriteLine(mathErrorMessage);
            Restart();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1304:Specify CultureInfo", Justification = "Same locale issue.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "Same issue.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "Leave my strings in peace. They won't kill anyone.")]
        private static void Restart()
        {
            Console.WriteLine();
            Console.WriteLine("Restart? y/n:");

            try
            {
                char restartInput = Convert.ToChar(Console.ReadLine());

                switch (char.ToLower(restartInput))
                {
                    case 'y':
                        Main();
                        break;
                    case 'n':
                        End();
                        break;
                    default:
                        Console.WriteLine("Invaild Input");
                        Restart();
                        break;
                }
            }

            catch (System.FormatException)
            {
                Console.WriteLine("Invaild Input");
                Restart();
            }

        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "Please, I beg of you. Just leave the strings.")]

        //Method for ending the program.
        private static void End()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
            System.Environment.Exit(1);
        }
    }
}