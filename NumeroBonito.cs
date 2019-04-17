using System;
using System.Collections.Generic;
using System.Linq;

namespace KlingonNumero
{
    class NumeroBonito
    {
        static void Main(string[] args)
        {

            string[] lines = System.IO.File.ReadAllLines(@"C:\Work\Financas360\textoB.txt");
            string[] linesNotDup = lines.Distinct().ToArray();

            GetNumber(linesNotDup);
        }

        private static void GetNumber(string[] linesNotDup)
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
                    ///-é maior ou igual a 440566 - é divisível por 3
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
            List<string> li = new List<string>
            {
                "k",
                "b",
                "w",
                "r",
                "q",
                "d",
                "n",
                "f",
                "x",
                "x",
                "j",
                "m",
                "l",
                "v",
                "h",
                "t",
                "c",
                "g",
                "z",
                "p",
                "s"
            };

            int ValorLetra = li.IndexOf(letra);

            return (ValorLetra - 1);
        }
    }
}
