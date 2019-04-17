using System;
using System.Collections.Generic;

namespace KlingonShort
{
    class Sort
    {
        public class KlingonSort
        {
            public static void Main()
            {
                string[] lines = System.IO.File.ReadAllLines(@"C:\Work\Financas360\textoB.txt");
                PrintPalavrasOrdenadas1(lines);          

            }

            private static void PrintPalavrasOrdenadas1(string[] lines)
            {
                string chave = "kbwrqdnfxjmlvhtcgzps";

                string[] ListPalavras;

                foreach (string line in lines)
                {
                    ListPalavras = line.Split(' ');

                    for (int nLetra = 0; nLetra < chave.Length; nLetra++)
                    {
                        foreach (string palavra in ListPalavras)
                        {
                            if (palavra[0] == chave[nLetra])
                            {
                                Console.WriteLine(palavra.Replace("\n", "").Replace("\r", " ")); 
                            }
                        }
                    }
                }
                Console.ReadKey();
            }

        }
    }

}