using System;
namespace inl_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxtal = int.MinValue;
            bool fortsätt = true;

            while (fortsätt)
            {
                Console.WriteLine("skriv in ett heltal:");
                int tal = int.Parse(Console.ReadLine());

                if ( tal > maxtal )
                {
                    maxtal = tal;
                }
                Console.WriteLine("vill du skriva in ett tal till? (ja/nej)");
                string svar = Console.ReadLine().ToLower();

                if (svar != "ja")
                {
                    fortsätt = false;
                }
            }
            Console.WriteLine($"det största talet du skrev in var: {maxtal}");
            Console.ReadKey();
        }
    }
}