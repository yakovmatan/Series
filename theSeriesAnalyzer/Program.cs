using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSeriesAnalyzer
{
    internal class Program
    {

        // function to get input.
        static string[] Input()
        {
            Console.WriteLine("Enter at least three numbers separated with spaces");
            string[] output = Console.ReadLine().Split(' ');
            return output;

        }

        // function to check if valid input.
        static bool IsValidInput(string[] array)
        {
            int Count = 0; 
            foreach (string item in array)
            {
                if (!int.TryParse(item,out int number))
                {
                    return false;
                }
                else if (number > 0) 
                {
                    Count++;
                }

            }
            if (Count >= 3) 
                return true;
            return false;
            
        }

        // function to convert string array to int array.
        static int[] FromStringToNumbers(string[] arrayString)
        {
            int[] arraysNum = new int[arrayString.Length];
            for (int i = 0; i < arrayString.Length; i++)
                arraysNum[i] = int.Parse(arrayString[i]);
            return arraysNum;

        }

        // function to display the series
        static void DisplaySeries(List<int> arrayInt)
        {
            foreach (int i in arrayInt)
            {
                Console.WriteLine(i);
            }
        }
        
        // function to display the series in revers
        static void ReversSeries(List<int> arrrayInt)
        {
            for (int i = arrrayInt.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(arrrayInt[i]);
            }
        }

        // function to display the series in sorted
        static void SortedSeries(List<int> arrayInt)
        {
            // copy to array
            List<int> ints = new List<int>(arrayInt);
            bool flag;
            for (int i = 0; i < arrayInt.Count - 1;i++)
            {
                flag = false;
                for (int j = 0; j < arrayInt.Count - 1 -i; j++)
                {
                    if (ints[j] > ints[j + 1])
                    {
                        int temp = ints[j];
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                        flag = true;
                    }
                }
                if(!flag)
                    break;


            }
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
                
            
        }

        // function to display the maximun
        static void MaxOfSeries(List<int> arrayInt)
        {
            int maximum = arrayInt[0];
            foreach (int i in arrayInt)
                if (i > maximum)
                {
                    maximum = i;
                }
            Console.WriteLine($"the max number is: {maximum}");
        }

        // function to display the minmum
        static void MinOfSeries(List<int> arrayInt)
        {
            int minimum = arrayInt[0];
            foreach(int i in arrayInt)
                if(i <  minimum)
                {
                    minimum = i;
                }
            Console.WriteLine($"the min number is: {minimum}");
        }
        
        // function to display the average
        static void AverageOfSeries(List<int> arrayInt)
        {
            int count = 0;
            int sum = 0;
            foreach (int i in arrayInt)
            {
                sum += i;
                count++;
            }
            Console.WriteLine((double)sum / count);
        }

        // function to display length of the series
        static void LengthOfSeries(List<int> arrayInt)
        {
            int length = 0;
            for (int i = 0; i < arrayInt.Count; i++)
            
                length++;
            
                

            Console.WriteLine(length);
        }

        // function to display sum of the series
        static void SumOfSeries(List<int> arrayInt)
        {
            int sum = 0;
            for (int i = 0;i < arrayInt.Count;i++)
            {
                sum += arrayInt[i];
            }
               

            Console.WriteLine(sum);
        }

        static void ShowMenu()
        {
            Console.WriteLine("Enter your choose:\n\n" +
                    "a.Input a Series. (Replace the current series)\n" +
                    "b.Desplay the series in the order it was entered.\n" +
                    "c.Display the series in the reversed order it was entered.\n" +
                    "d.Display the series in sorted order (from low to high).\n" +
                    "e.Display the Max value of the series.\n" +
                    "f.Display the Miin value of the series.\n" +
                    "g.Display the Average of the series.\n" +
                    "h.Display the Number of eements in the series.\n" +
                    "i.Display the Sum of the series.\n" +
                    "j.Exit\n");

        }

        // function to restart series
        static void New(List<int> arrayInt)
        {
            string[] input = Input();
            if (IsValidInput(input))
            {
                arrayInt.Clear();
                int[] updateInput = FromStringToNumbers(input);// convert input to int
                arrayInt.AddRange(updateInput);// enter input to list main
                Console.WriteLine("-------------------\nyour input is valid\n-------------------");

            }
            else
            {
                Console.WriteLine("your input not valid");
                if (arrayInt.Count == 0)
                    New(arrayInt);

                else
                {
                    Console.WriteLine("Because your input was invalid, you are left with the previous list.");
                }
            }
            


        }


        static void Main(string[] args)
        {
            List<int> ints = new List<int>();

            // checking if there are arguments
            if (args.Length > 0)
            {
                if (IsValidInput(args))
                {
                    int[] updateArgs = FromStringToNumbers(args);
                    ints.AddRange(updateArgs);
                }

            }
            else
            {
                Console.WriteLine("There is no list in the system yet");
                New(ints);
                
            }

            string yourChoose = "";
            

            do
            { 
                ShowMenu();
                yourChoose = Console.ReadLine();

                switch (yourChoose)
                {
                    case "a":
                        New(ints);
                        break;

                    case "b":
                        DisplaySeries(ints);
                        break;

                    case "c":
                        ReversSeries(ints);
                        break;

                    case "d":
                        SortedSeries(ints);
                        break;

                    case "e":
                        MaxOfSeries(ints);
                        break;

                    case "f":
                        MinOfSeries(ints);
                        break;

                    case "g":
                        AverageOfSeries(ints);
                        break;

                    case "h":
                        LengthOfSeries(ints);
                        break;

                    case "i":
                        SumOfSeries(ints);
                        break;

                    default:
                        if (yourChoose == "j")
                            break;
                        else
                        {
                            Console.WriteLine("your choose not between a-j enter choose again\n");
                            break;

                        }
                            
                      


                }
            }
            while (yourChoose != "j");
            Console.WriteLine("Good Bye");

        }
    }
}
