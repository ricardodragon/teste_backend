using System;
using System.Collections.Generic;
using System.Linq;

namespace exe1
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<List<int>> collatz = new List<List<int>>();          
            List<int> lista; 
            int i;
            for(int j=10000; j>1; j--){
                lista = new List<int>();
                i=j;
                if(verificaExistencia(collatz, i))
                    i=1;
                while(i>1){
                    if(verificaExistencia(collatz, i)){
                        Console.WriteLine("Erro aqui não");
                        lista.AddRange(retornaListaParcial(collatz, i));
                        i=1;
                    }
                    else{
                        lista.Add(i);
                        if(i%2==0)
                            i/=2;
                        else
                            i=3*i+1;                
                    }
                }
                lista.Add(i);
                collatz.Add(lista);
            }
            foreach(int t in collatz.Where(x=>x.Count()==collatz.Max(y=>y.Count())).FirstOrDefault())
                Console.Write(t+",\t");
        }   

        public static bool verificaExistencia(List<List<int>> collatz, int num){
            Console.WriteLine("Erro aqui");
            return collatz.Where(x=>x.Where(y=>y==num).Count()>0).Count()>0;
        }
        public static List<int> retornaListaParcial(List<List<int>> collatz, int num){
            return collatz.Where(x=>x.Where(y=>y==num).Count()>0).FirstOrDefault();
        }
    }
}
