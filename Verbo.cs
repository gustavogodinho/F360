using System;
using System.Collections.Generic;
using System.Linq;

namespace KlingonVerbos
{
    class Verbo
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Work\Financas360\textoB.txt");
            string[] linesNotDup = lines.Distinct().ToArray();

            string[] Words;
            int countVerbo = 0;
            int countVerboPri = 0;

            foreach (string line in linesNotDup)
            {
                Words = line.Split(' ');

                foreach (string word in Words)
                {
                    if (word.Length >= 8)
                    {
                        if (LetraFoo(word))
                        {
                            countVerbo = countVerbo + 1;

                            if (LetraBar(word))
                            {
                                countVerboPri = countVerboPri + 1;
                            }

                        }
                    }
                }

            }

            Console.WriteLine("Qtd Verbos: " + countVerbo);
            Console.WriteLine("Qtd Primeira Pessoa: " + countVerboPri);
            Console.ReadKey();


        }

        private static bool LetraFoo(string word)
        {
            {
                bool retorno = false;
                List<string> li = new List<string>
            {
                "k",
                "w",
                "f",
                "l",
                "s"
            };

                for (int i = 0; i < li.Count; i++)
                {
                    if (word.Substring(word.Length - 1, 1) == li[i])
                    {
                        retorno = true;
                        break;
                    }
                    else
                    {

                    }
                }
                return retorno;
            }
        }

        private static bool LetraBar(string palavra)
        {
            bool retorno = false;
            List<string> li = new List<string>
            {
                "b",
                "r",
                "q",
                "d",
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
                if (palavra.Substring(palavra.Length - 8, 1) == li[i])
                {
                    retorno = true;
                    break;
                }
                else
                {

                }
            }
            return retorno;
        }
    }



}
