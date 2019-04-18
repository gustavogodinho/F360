using System;
using System.Collections.Generic;
using System.Linq;

namespace KlingonNumero
{
    class NumeroBonito
    {
        private static void Main()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Work\Financas360\textoB.txt");
            string[] linesNotDup = lines.Distinct().ToArray();

            ObterNumero(linesNotDup);
        }

        private static void ObterNumero(string[] linesNotDup)
        {
            string[] Words;
            int countNumeroBonito = 0;

            foreach (string line in linesNotDup)
            {
                Words = line.Split(' ');

                foreach (string line2 in Words)
                {
                    double numero = 0.0;
                    string letra = "";

                    for (int i = 0; i < line2.Length; i++)
                    {
                        letra = line2.Substring(i, 1);
                        numero += Math.Pow(20, i) * PesoLetra(letra);
                    }
                    if (numero >= 440566 && ((numero % 3) == 0))
                    {
                        countNumeroBonito = (countNumeroBonito + 1);
                    }
                }
                Console.WriteLine("Números bonitos distintos: " + countNumeroBonito);
                Console.ReadKey();
            }
        }
        private static int PesoLetra(string letra)
        {
            string alfabetoKingon = "kbwrqdnfxxjmlvhtcgzps";
            int valorLetra = alfabetoKingon.IndexOf(letra);

            return (valorLetra - 1);
        }
    }
}
