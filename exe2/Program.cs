using System;
using System.Linq;

namespace exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            if(numeros.Where(x=>x%2==0).Count()==0)
                Console.WriteLine("Só tem impares");
            else
                Console.WriteLine("Tem pares");
        }
    }
}
