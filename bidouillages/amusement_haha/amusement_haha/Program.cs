using System;

namespace amusement_haha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("J'aime les ratons laveurs =) \nToi aussi ? O / N");

            string ans = Console.ReadLine();
            while (ans != "O" && ans != "o" && ans != "N" && ans != "n")
            {
                Console.WriteLine("Réponds en tapant 'O' (oui) ou 'N' (non)");
                ans = Console.ReadLine();
            }

            if (ans == "O" || ans == "o")
            {
                Console.WriteLine("Ouais ! T'es mon copain ! Ou ma copine, si t'es une fille... =)");
            }

            else 
            {
                Console.WriteLine("Pff, hérétique... Va gober des ascenseurs aquaphiles à double hélice en combinaison de ski...");
            }
        }
    }
}
