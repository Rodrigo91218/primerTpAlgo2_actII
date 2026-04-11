using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerTpAlgo2_actII
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            double mayor = 0;
            int num = 1;
            double numero = 0;
            int cantMayor = 1;
            Console.WriteLine("Ingrese 10 números");
            Console.Write($"Número {num}: ");
            
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Error!. Ingrese solo valores numericos.");
                Console.Write($"Número {num}: ");
            }
            mayor = numero;
            num++;
            for(int i = 1; i <10; i++)
            {
                Console.Write($"Número {num}: ");
                while (!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Error!. Ingrese solo valores numericos.");
                    Console.Write($"Número {num}: ");
                }
                if(numero > mayor)
                {
                    mayor = numero;
                    cantMayor = 0;
                }
                if(numero == mayor)
                {
                    cantMayor++;
                }
                num++;

            }
            if (cantMayor == 1)
            {
                Console.WriteLine($"\nEl número mayor que se ingreso fue: {mayor} y se repitió {cantMayor} vez."); 
                
            }
            else
            {
                Console.WriteLine($"\nEl número mayor que se ingreso fue: {mayor} y se repitió {cantMayor} veces.");
                
            }
            Console.ReadKey();



        }
    }
}
