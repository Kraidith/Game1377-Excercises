using System.Diagnostics.CodeAnalysis;
using System.Reflection;

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
         Methods();
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
            //b
            int intArrayIndex = intArray.Length - 1;
            while(intArrayIndex >= 0)
            {
                Console.WriteLine("Reverse: " + intArray[intArrayIndex]);
                intArrayIndex--;
            }
            //c
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
            //d
            int sum = 0; 
            for (int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }
            int average = sum / intArray.Length;
            Console.WriteLine("Sum from the loop: " + sum);
            Console.WriteLine("Average: " + average);
            //e
            for (int i =0; i < intArray.Length; i++)
            {
              if(i % 2 == 1)
              {
                    continue;
              }
                Console.WriteLine(intArray[i]);
            }
            //f
            for(int i = 0; i < intArray.Length; i++)
            {
                if(i % 3 != 0)
                {
                    continue;
                }
                Console.WriteLine(intArray[i]);
            }
            //g

        }

        private static void Methods()
        {

        }
    }
}
