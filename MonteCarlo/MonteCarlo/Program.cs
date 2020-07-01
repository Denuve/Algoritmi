using System;

namespace MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rewards = { "Asus Zenfone 7", "surub", "castravete", "carte", "suc" };
            int[] chances = { 1, 49, 35, 5, 10 };
            int credit = 1500;

            Random rnd = new Random();
            int aux;
            int poz = 0;

            int total = 0;

            for (int i = 0; i < chances.Length; i++)
            {
                total += chances[i];
            }

            do
            {
                poz = 0;
                aux = rnd.Next(total);
                credit -= 15;
                while (aux >= 0)
                {
                    aux -= chances[poz];
                    poz++;
                }
                Console.WriteLine("Felicitari, ai castigat: {0}!", rewards[poz - 1]);
            } while (rewards[poz - 1] != "Asus Zenfone 7");


            Console.Write("Felicitari, ai castigat cel mai mare premiu, ai iesit pe - cu:{0} lei", credit);
            
            Console.ReadKey();
        }
    }
}
