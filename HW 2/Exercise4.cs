using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace HW_2
{
    internal class Exercise4
    {
        enum movementKey
        {
         W,
         A,
         S,
         D
        }
        static void Main(string[] args)
        {
         Switch();
         ArraysAndLoops();
            int[] intArray = { 14, 25, 36, 47, 58 };
            float[] floatArray = { 16.0f, 27.0f, 38.0f, 49.0f, 60.0f };
            double[] doubleArray = { 15.0, 30.0, 45.0, 60.0, 75.0 };
            int[] arrayMin = { 0 };
            int[] arrayMax = { 10 };
            Methods(intArray);
            Methods(floatArray);
            Methods(doubleArray);
            Console.WriteLine("Average (int): " + Average(intArray));
            Console.WriteLine("Average (float): " + Average(floatArray));
            Console.WriteLine("Average (double): " + Average(doubleArray));
            int arraySize = int.Parse(Console.ReadLine());
            int rangeMin = int.Parse(Console.ReadLine());
            int rangeMax = int.Parse(Console.ReadLine());
            Console.WriteLine("Input length of the array:");
            Console.WriteLine("Input Min range value of the array");
            Console.WriteLine("Input max range values of th array");
            int[] randomArray = RandomArray(arraySize, arrayMin, arrayMax);
        } 

        private static void Switch()
        {
            Console.WriteLine("input a WASD key (Enter a number 0-3 inclusive )");
            ConsoleKeyInfo inputKey = Console.ReadKey(); 
            int.TryParse(inputKey.KeyChar.ToString(), out int result);
            Enum movementKey = (movementKey)result;
            Console.ReadLine();
            switch (result)
            {
                case 0:
                    Console.WriteLine("You moved up");
                    break;
                case 1:
                    Console.WriteLine("You moved down");
                    break;
                case 2: 
                    Console.WriteLine("You moved left");
                    break;
                case 3:
                    Console.WriteLine("You moved right");
                    break;
            }

        }

        private static void ArraysAndLoops()
        {
            int[] intArray = { 100 , 94, 159, -783, 132, 179, 47, 107, 135, 50};
            int intArrayIndex = intArray.Length - 1;
            while(intArrayIndex >= 0)
            {
                Console.WriteLine("Reverse: " + intArray[intArrayIndex]);
                intArrayIndex--;
            }
            Random rnd = new Random();
            int randomIndex = 0;
            int chosenNumber = intArray[7];
            Console.WriteLine("Guess the number: " + intArray[randomIndex]);
            while (intArray[randomIndex] != chosenNumber)
            {
                randomIndex = rnd.Next(intArray.Length);
                Console.WriteLine("Guess the number: " + intArray[randomIndex]);
            }
            Console.WriteLine(" Yay! you got the Index: " + intArray[randomIndex]);
            int sum = 0; 
            for (int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }
            int average = sum / intArray.Length;
            Console.WriteLine("Sum from the loop: " + sum);
            Console.WriteLine("Average: " + average);
            for (int i =0; i < intArray.Length; i++)
            {
              if(i % 2 == 1)
              {
                    continue;
              }
                Console.WriteLine(intArray[i]);
            }
            for(int i = 0; i < intArray.Length; i++)
            {
                if(i % 3 != 0)
                {
                    continue;
                }
                Console.WriteLine(intArray[i]);
            }
            Console.WriteLine("InputLength of the array");
            int arraySize = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Min range value of the array");
            int rangeMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Max range value of the array");
            int rangeMax = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            _ = new Random();
            for (int i =0; i < array.Length; i++)
            {
                array[i] = rnd.Next(rangeMin, rangeMax + 1);
            }
            Console.WriteLine("Generated new array");
        }

        private static void Methods(int[] array)
        {
            Console.WriteLine("Integer array elements");
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }
        private static void Methods(float[] array)
        {
            Console.WriteLine("Float array elements");
            foreach(float i in array)
            {
                Console.WriteLine(i);
            }
        } 

        private static void Methods(double[] array)
        {
            Console.WriteLine("Double array elements");
           foreach(double i in array)
           {
                Console.WriteLine(i);
           }
        }
        private static float Average(int[] array)
        {
            int sum = 0;
            foreach(int i in array)
            {
                sum += i;
            }
            return (float)sum / array.Length;
        }
        private static float Average(float[] array)
        {
            float sum = 0;
            foreach(float i in array)
            {
             sum += i;
            }
            return (float)sum / array.Length;
        }
        private static double Average(double[] array)
        {
            double sum = 0;
            foreach (double i in array)
            {
                sum += i;
            }
            return (double)sum / array.Length;
        }
        private static int[] RandomArray(int arraySize, int[] rangeMin, int[] rangeMax)
        {
            Random rnd = new Random();
            int[] array = new int[arraySize];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(rangeMin[0], rangeMax[0] + 1);
            }
            return array;
        }
    }
     
}
