using System;
using System.Linq;

namespace KlingonVerbos
{
    class Verbo
    {
        private static void Main()
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
                string letrasFoo = "kwfls";
            
                for (int i = 0; i < letrasFoo.Length; i++)
                {
                    if (word.Substring(word.Length - 1, 1) == letrasFoo[i].ToString())
                    {
                        retorno = true;
                        break;
                    }
                }
                return retorno;
            }
        }
        private static bool LetraBar(string palavra)
        {
            bool retorno = false;
            string letrasBar = "brqdnxjmvhtcgzp";
                        
            for (int i = 0; i < letrasBar.Length; i++)
            {
                if (palavra.Substring(palavra.Length - 8, 1) == letrasBar[i].ToString())
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
    }
}
