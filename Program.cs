using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Quanti corridori ci sono nella corsa?");
            int corridori = int.Parse(Console.ReadLine());
            string[] nomi_corridori = new string[corridori];
            string nome;
            for (int i = 1; i <= corridori; i++)
            {
                Console.WriteLine($"nome del corridore numero: {i}");
                nome = Console.ReadLine();
                nomi_corridori[i] = nome;
                
                if(i == corridori)
                {
                    
                    for (int l = 0; l <= corridori; l++)
                    {
                        Thread t1 = new Thread(() => IniziaCorsa());
                        t1.Start();
                    }
                }
            }

            void IniziaCorsa()
            {
                for (int j = 0; j <= 100; j++)
                {
                    Console.WriteLine($"corridore: {nomi_corridori} ha compiuto: {j} metri");
                    if(j == 100)
                    {
                        Console.WriteLine($"il corridore: {nomi_corridori} ha vinto");
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
