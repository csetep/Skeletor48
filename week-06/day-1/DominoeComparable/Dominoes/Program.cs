using System;
using System.Collections.Generic;

namespace Domino
{
    public class Dominoes
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();

            dominoes.Sort();

            foreach (var domino in dominoes)
            {
                Console.WriteLine(domino.GetValues()[0] + " " + domino.GetValues()[1] + " | ");
            }

            Console.ReadKey();
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>
            {
                new Domino(5, 2),
                new Domino(4, 6),
                new Domino(1, 5),
                new Domino(6, 7),
                new Domino(2, 4),
                new Domino(7, 1),
                new Domino(6, 4)
            };
            return dominoes;
        }
    }
}
