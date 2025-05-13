using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSeriesAnalyzer
{
    internal class Program
    {
        
        static string[] Input()
        {
            Console.WriteLine("Enter at least three numbers separated with spaces");
            string[] output = Console.ReadLine().Split(' ');
            return output;

        }

        static void IsValidInput()
        {
            
        }

        static void FromStringToNumbers()
        {

        }

        static void DisplaySeries()
        {
            Console.WriteLine("you choose b");
        }
        
        static void ReversSeries()
        {
            Console.WriteLine("you choose c");
        }

        static void SortedSeries()
        {
            Console.WriteLine("you choose d");
        }

        static void MaxOfSeries()
        {
            Console.WriteLine("you choose e");
        }

        static void MinOfSeries()
        {
            Console.WriteLine("you choose f");
        }
        
        static void AverageOfSeries()
        {
            Console.WriteLine("you choose g");
        }

        static void LengthOfSeries()
        {
            Console.WriteLine("you choose h");
        }

        static void SumOfSeries()
        {
            Console.WriteLine("you choose i");
        }

        
        static void Main(string[] args)
        {

            string yourChoose = "";

            do
            {
                Console.WriteLine("Enter your choose:\na. Input a Series. (Replace the current series)\nb.Desplay the series in the order it was entered.\nc.Display the series in the reversed order it was entered.\nd.Display the series in sorted order (from low to high).\ne. Display the Max value of the series.\nf. Display the Miin value of the series.\ng. Display the Average of the series.\nh. Display the Number of eements in the series.\ni. Display the Sum of the series.\nj. Exit");
                yourChoose = Console.ReadLine();

                switch (yourChoose)
                {
                    case "a":
                        Input();
                        break;

                    case "b":
                        DisplaySeries();
                        break;

                    case "c":
                        ReversSeries();
                        break;

                    case "d":
                        SortedSeries();
                        break;

                    case "e":
                        MaxOfSeries();
                        break;

                    case "f":
                        MinOfSeries();
                        break;

                    case "g":
                        AverageOfSeries();
                        break;

                    case "h":
                        LengthOfSeries();
                        break;

                    case "i":
                        SumOfSeries();
                        break;

                    default:
                        if (yourChoose == "j")
                            break;
                        else
                        {
                            Console.WriteLine("enter valid value");
                            break;

                        }
                            
                      


                }
            }
            while (yourChoose != "j");
            Console.WriteLine("Good Bye");

        }
    }
}
