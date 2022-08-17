using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace TP.Aula05Exer02
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string comandocshap = "if x > y";
            //Console.WriteLine("Digite um comando em C#");
            //comandocshap = Console.ReadLine();

            string[] comandosplitado = comandocshap.Split(" ");

            Dictionary<string, string> tradutor = new();

            tradutor.Add("if", "se");
            tradutor.Add("while", "enquanto");
            tradutor.Add(">", "maior que");
            tradutor.Add("<", "menor que");
            tradutor.Add(">=", "maior igual que");
            tradutor.Add("<=", "menor igual que");
            tradutor.Add("=", "igual a");
            tradutor.Add("!=", "diferente de");

            for (int j = 0; j < comandosplitado.Length; j++)
            {
                foreach (KeyValuePair<string, string> par in tradutor)
                {
                    if (par.Key == comandosplitado[j])
                    {
                        comandosplitado[j] = par.Value;
                    }
                }
            }

            string comandoreconcac = String.Join(" ", comandosplitado);

            Console.WriteLine(comandoreconcac);
        }
    }

}