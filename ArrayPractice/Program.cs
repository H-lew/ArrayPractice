using System.Globalization;
using System.Runtime.InteropServices;

namespace ArrayPractice
{
    internal class Program
    {
        //Each to be done in a seperate function:
        //Smallest and largest number in an array
        //Mean, median, and mode of an array
        //reverse an array
        //sort an array
        //reverse a string(ask instructor before attempting)
        //palindrome detector
        //palindrome detector without allocating new string


        static void Main()// its unused and idk what its for
        {



            //int[] example;
            //example = new int[3];
            //example[0] = 1;
            //example[1] = 2;
            //example[2] = 3;

            //int[] shorterExample;
            //shorterExample = new int[3] { 1, 2, 3 };

            //int[] evenShorterExample;
            //evenShorterExample = new int[] { 1, 2, 3 };

            //int[] evenEvenShorterExample = { 1, 2, 3 };

            //int[] differentExample = [1, 2, 3];

            //int[] loopExample = new int[3];
            //for (int i = 0; i < loopExample.Length; i++)
            //{
            //    loopExample[i] = i;
            //}

            Random random = new();
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int randomNum = random.Next(100);
                array[i] = randomNum;
            }


            Print(array);
            Console.WriteLine();

            Console.WriteLine($"Smallest is: {EatSmallest(array)}");
            Console.WriteLine($"Biggest is: {EatBiiggest(array)}");
            Console.WriteLine($"Mean is: {Mean(array)}");
            Console.WriteLine($"Median is: {Median(array)}");
            Console.WriteLine($"Mode is: {Mode(array)}");
            Console.WriteLine("Reversed array is:");
            int[] REALrevArray = Reverse(array);
            //1, 1, 2, 2, 2, 2, 2, 5, 5, 10
            for (int i = 0; i < REALrevArray.Length; i++)
            {
                Console.WriteLine($"{REALrevArray[i]}");
            }

            Console.WriteLine("Sorted array is:");
            int[] REALsortArray = Sort(array);
            for (int i = 0; i < REALsortArray.Length; i++)
            {
                Console.WriteLine($"{REALsortArray[i]}");
            }

            Console.WriteLine("reverced string is:");
            string REALRevString = ReverseString("Cowabunga");
            for (int i = 0; i < REALRevString.Length; i++)
            {
                Console.WriteLine($"{REALRevString[i]}");
            }


        }

        static void Print(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }

        static int EatSmallest(int[] numbers)
        {


            int idk = numbers[1];
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] < idk)
                {
                    idk = numbers[i];
                }
            }
            //Console.WriteLine($"SMALLEST:{idk}");
            return (idk);

        }
        static int EatBiiggest(int[] numbers)
        {
            int idk = numbers[1];
            for (int i = 0; i > numbers.Length; i++)
            {

                if (numbers[i] > idk)
                {
                    idk = numbers[i];
                }
            }
            //Console.WriteLine($"BIIGGEST:{idk}");
            return (idk);
        }
        static int Mean(int[] numbers)
        {
            int mean = 0;
            for (int i = 0; i > numbers.Length; i++)
            {
                mean = numbers[i] + mean;
            }
            mean /= numbers.Length;
            // Console.WriteLine($"MEAN:{mean}");

            return (mean);
        }
        static int Median(int[] numbers)
        {
            int med = numbers.Length / 2;
            med = numbers[med];
            //   Console.WriteLine($"MEDIAN:{med}");

            return (med);
        }
        //look at mc PAINT TO REMEMBER   V
        static int Mode(int[] numbers)
        {
            int[] numbers2 = new int[10];
            for (int i = 0; i == numbers.Length; i++)
            {
                numbers2[i] = numbers[i];
            }

            for (int i = 0; i < numbers2.Length; i++)
            {
                int smaller = i;
                for (int j = i; j < numbers2.Length; j++)
                {
                    if (numbers2[j] < numbers2[smaller])
                    {
                        smaller = j;
                    }
                }

                int extra = numbers2[i];
                numbers2[i] = numbers2[smaller];
                numbers2[smaller] = extra;
            }







            int mode = numbers[0];
            int modeCount = 0;
            int CurrentCount = 0;
            for (int i = 0; i != numbers.Length - 1; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber == numbers[i])
                {
                    if (currentNumber != numbers[0])
                    {
                        if (currentNumber != numbers[i - 1])
                        {
                            CurrentCount = 0;
                        }
                    }
                    CurrentCount++;
                    if (modeCount < CurrentCount)
                    {
                        mode = numbers[i];
                        modeCount = CurrentCount;

                    }
                }

            }


            return (mode);
        }

        //numbers =10 length     ljnjbkjbkjhbkjbjkb            rev = 9 length c
        static int[] Reverse(int[] numbers)
        {
            int[] REVarray = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                REVarray[i] = numbers[numbers.Length - i - 1];
            }

            return REVarray;

        }
        static int[] Sort(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                int smaller = i;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[smaller])
                    {
                        smaller = j;
                    }
                }

                int extra = numbers[i];
                numbers[i] = numbers[smaller];
                numbers[smaller] = extra;

                //for (int k = 0; k < numbers.Length; k++)
                //{
                //    if (numbers[k] == smaller)
                //    {
                //        numbers[k] = extra;
                //    }
                //}

            }
            return numbers;
        }
        static string ReverseString(string input)
        {
            //  int[] data = new int[10];
            char[] chars = new char[input.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = input[i];
            }
            //string[] REVarray = new Array 
            

            for (int i = chars.Length ; i > 0; i--)
            { 
                char RevChar = chars[i-1];//NOT REVERCIMG FIX 
            }

            string RevString = "";

            for (int i = 0; i < chars.Length; i++)
            {
                RevString += chars[i];
            }

            return RevString;
            //chars[i] = input
            //     copy data to new char array from og string
            // rev data like int array
            // copy data from new chars to string -----finiish this
        }
    }
}