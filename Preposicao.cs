using System;
using System.Collections.Generic;

namespace Klingon
{
    class Preposicao
    {

        static void Main(string[] args)
        {

            string[] lines = System.IO.File.ReadAllLines(@"C:\Work\Financas360\textoB.txt");

            string[] Words;
            int count = 0;

            foreach (string line in lines)
            {
                Words = line.Split(' ');

                foreach (string word in Words)
                {
                    //preposição
                    if (word.Length == 3 && (!word.Contains("d")))
                    {

                        if (LetraBar(word))
                        {
                            count = count + 1;
                        }
                    }
                }

            }
            Console.WriteLine("Qtd Preposições: " + count);
            Console.ReadKey();


        }

        private static bool LetraBar(string palavra)
        {
            bool retorno = false;
            List<string> li = new List<string>
            {
                "b",
                "r",
                "q",
               // "d",
                "n",
                "x",
                "j",
                "m",
                "v",
                "h",
                "t",
                "c",
                "g",
                "z",
                "p"
            };

            for (int i = 0; i < li.Count; i++)
            {
                if (palavra.Substring(palavra.Length - 1, 1) == li[i])
                {
                    retorno = true;
                }
                else
                {
                  
                }
            }
            return retorno;
        }
    }
}
