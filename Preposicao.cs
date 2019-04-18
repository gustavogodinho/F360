using System;

namespace Klingon
{
    class Preposicao
    {
        private static void Main()
        {
            string[] Lines = System.IO.File.ReadAllLines(@"C:\Work\Financas360\textoB.txt");
            string[] Words;
            int count = 0;

            foreach (string line in Lines)
            {
                Words = line.Split(' ');

                foreach (string word in Words)
                {
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
            string letrasBar = "brqdnxjmvhtcgzp";

            for (int i = 0; i < letrasBar.Length; i++)
            {
                if (palavra.Substring(palavra.Length - 1, 1) == letrasBar[i].ToString())
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
    }
}
