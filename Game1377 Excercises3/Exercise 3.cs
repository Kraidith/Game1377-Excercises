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
            int intInput1 = 9002;
            int intInput2 = 1471;
            int sum= intInput1 + intInput2;
            int diff = intInput1 - intInput2; 
            int product = sum + diff; 
            float quotient_float = (float)intInput1 / intInput2; //so puting a different type in () will change it from an int to a float? yes it does cool 
            int remainder = intInput1 % intInput2;
            Console.WriteLine(intInput1);
            Console.WriteLine(intInput2);
            Console.WriteLine(sum);
            Console.WriteLine(diff);
            Console.WriteLine(product);
            Console.WriteLine(quotient_float);
            Console.WriteLine(remainder);

        }
        static void Assignment()
        {
            float floatInput1 = 976f;
            float floatInput2 = 7698f;
            floatInput1 += floatInput2; //ok so = is needed but i need the the arithmetic, I don't need it to say float since it's already declared, keep that in mind
            floatInput1 -= floatInput2;
            floatInput1 -= floatInput2;
            floatInput1 /= floatInput2;
            Console.WriteLine(floatInput1);
            Console.WriteLine(floatInput2);
        }


        static void ComparisonAndConditionals()
        {
            int intInput1 = 654, intInput2 = 2775;
            bool isintInput1GreaterThanintInput2 = false;
            bool isintInput1EqualtointInput2 = intInput1 == intInput2;

            Console.WriteLine(intInput1);
            Console.WriteLine(intInput2);
            if (isintInput1GreaterThanintInput2)
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

