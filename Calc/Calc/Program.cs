using System;


/*
Create a new Console Application called Calc
void AskValues():
Display instructions thanks to Console.WriteLine
Ask for two float numbers and one operator with Console.ReadLine
Call Compute

float Compute(float n1, float n2, int operation):
Switch on operator to compute  the result
Return the result
*/

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            AskValues();
        }

        static void AskValues()
        {
            Console.Write("Enter a float value: ");
            float n1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("You typed " + n1);

            Console.Write("Enter another float value: ");
            float n2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("You typed " + n2);

            int operation = 0;

            while (operation != 1 && operation != 2 && operation != 3 && operation != 4)
            {
                Console.WriteLine("1. +\n2. -\n3. *\n4. /");
                Console.Write("Enter an operator: ");
                operation = Convert.ToInt32(Console.ReadLine());
                if (operation != 1 && operation != 2 && operation != 3 && operation != 4)
                    Console.WriteLine("Merci de rentrer un nombre valide, illettré...");
            }
            Console.WriteLine("You typed " + operation);

            Console.WriteLine(Compute(n1, n2, operation));
        }

        static float Compute(float n1, float n2, int operation)
        {
            switch (operation)
            {
                case 1:
                    return n1 + n2;
                case 2:
                    return n1 - n2;
                case 3:
                    return n1 * n2;
                case 4:
                    return n1 / n2;
                default:
                    Console.WriteLine(@"Je sais même pas comment tu es entré dans le ""default"", bravo...");
                    return 0;
            }
        }
    }
}
