using System;
using System.Collections.Generic;

namespace KlingonShort
{
        public class KlingonSort
        {
            public static void Main()
            {
                string[] Lines = System.IO.File.ReadAllLines(@"C:\Work\Financas360\textoB.txt");
                PrintPalavrasOrdenadas(Lines);          

            }

            private static void PrintPalavrasOrdenadas(string[] lines)
            {
                string ordem = "kbwrqdnfxjmlvhtcgzps";
                string[] ListPalavras;

                foreach (string line in lines)
                {
                    ListPalavras = line.Split(' ');

                    for (int nLetra = 0; nLetra < ordem.Length; nLetra++)
                    {
                        foreach (string palavra in ListPalavras)
                        {
                            if (palavra[0] == ordem[nLetra])
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

