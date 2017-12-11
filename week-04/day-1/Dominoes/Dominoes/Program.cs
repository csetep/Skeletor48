using System;
using System.Collections.Generic;

namespace Domino
{
    public class Dominoes
    {

        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();

            int counter = 7;
            int indexRight = 0;

            Console.Write("[5][2]");
            DominoSort(indexRight, dominoes, counter);
            Console.ReadKey();
        }

        private static void DominoSort(int indexRight, List<Domino> dominoes, int counter)
        {
            while (counter > 0)
            {
                for (int indexLeft = 0; indexLeft < 6; indexLeft++)
                {
                    int rightTile = dominoes[indexRight].GetValues()[1];
                    int leftTile = dominoes[indexLeft].GetValues()[0];
                    int[] dominoesArray = dominoes[indexLeft].GetValues();

                    if (leftTile == rightTile)
                    {
                        foreach (var domino in dominoesArray)
                        {
                            Console.Write("[{0}]", domino);
                        }
                        indexRight = indexLeft;
                        counter--;
                    }
                }
            }
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}
