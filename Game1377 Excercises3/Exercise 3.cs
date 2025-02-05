using System.Net.Http.Headers;

namespace Game1377_Excercises3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Main\n");
            OutgoingStrings();
            Arithmetic();
            Assignment();
            ComparisonAndConditionals();
        }
        static void OutgoingStrings()
        {
            string Game1377 = "I'm in Game 1377: Scripting for Game Designers.";
            Console.WriteLine(Game1377);
            Console.WriteLine(Game1377 + "\n");
            Console.WriteLine(Game1377.ToUpper());
            Console.WriteLine(Game1377.ToLower());
            Console.WriteLine(Game1377.Substring(7));
            Console.WriteLine(Game1377.Substring(7,4));
            Console.WriteLine(Game1377.Substring(7,1));
        }
        static void Arithmetic()
        {
            string? inputString = Console.ReadLine(); //how to get an input
            int intInput1 = Convert.ToInt32(inputString); //convert from string to int
            string? inputString2 = Console.ReadLine(); //get another input
            int intInput2 = Convert.ToInt32(inputString2); //convert to string2
            int sum= intInput1 + intInput2;
            int diff = intInput1 - intInput2; 
            int product = sum * diff; 
            float quotient_float = (float)intInput1 / intInput2; //so puting a different type in () will change it from an int to a float? yes it does cool 
            int remainder = intInput1 % intInput2;
            Console.WriteLine(sum);
            Console.WriteLine(diff);
            Console.WriteLine(product);
            Console.WriteLine(quotient_float);
            Console.WriteLine(remainder);

        }
        static void Assignment()
        {
            string? floatString = Console.ReadLine();
            float floatInput = Convert.ToSingle(floatString);
            string? floatString2 = Console.ReadLine();
            float floatInput2 = Convert.ToSingle(floatString2); //ToSingle is for float ToInt32 is for int

            floatInput += floatInput2; //ok so = is needed but i need the the arithmetic, I don't need it to say float since it's already declared, keep that in mind
            floatInput -= floatInput2;
            floatInput -= floatInput2;
            floatInput /= floatInput2;
        }


        static void ComparisonAndConditionals()
        {
            string? inputString = Console.ReadLine(); 
            int intInput1 = Convert.ToInt32(inputString); 
            string? inputString2 = Console.ReadLine(); 
            int intInput2 = Convert.ToInt32(inputString2);
            if ( intInput1 >intInput2)
            {
                Console.WriteLine("intInput1 is greater than intInput2 according to the variable");
            }
            else if (intInput1 < intInput2)
            {
                Console.WriteLine("intInput1 is less than intInput2 according to the variable");
            }
            else
            {
                Console.WriteLine("the inputs are not equal");
            }
        }


    }
}

