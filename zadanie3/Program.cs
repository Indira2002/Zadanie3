using System;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
             int[] massiv = new int[] { 10, -3, -5, 2, 5 };
             int a = int.MaxValue; // MaxValue - свойство
             int ind = 0;
             for (int i = 0; i < massiv.Length; ++i)
             {
            int temp = Math.Abs(massiv[i]);
            if (a > temp)
             {
                 a = temp;
                 ind = i;
               }
              }
              Console.WriteLine("Индекс - " + ind);
              Console.ReadKey();
            //3
              Random rnd = new Random();
              int[] massi = new int[5];
              for (int i = 0; i < massi.Length; i++)
             {
                 massi[i] = rnd.Next(-10, 10);
             }
            for (int i = 0; i < massi.Length; i++)
            {
             Console.Write(massi[i] + " ");
            }

            Console.WriteLine();

             for (int i = 0; i < massi.Length; i++)
            {
            if (massi[i] < 0)
             {
                    massi[i] = 0;
             }
            }
             for (int i = 0; i < massi.Length; i++)
             {
                 Console.Write(massi[i] + " ");
             }
               Console.ReadKey();
            //2
            
             int[] mass = { 1, 5, 2, 1, 2, 3 };
            int size = mass.Length;
            for (int i = 0; i < size; i++)
            {
                if ((i == 0) || (i == 2 ) || (i == 3) || (i == 4))
                {
                    mass[i] = 0;
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.ReadKey();
        }
    }
}

