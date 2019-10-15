using System;
using System.Linq;

namespace exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };

            var result = primeiroArray.Where(x=> segundoArray.Contains(x));
            foreach(var item in result){
                Console.WriteLine(item);
            }

        }
    }
}
