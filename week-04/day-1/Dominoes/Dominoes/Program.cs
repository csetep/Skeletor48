using System;
using System.Collections.Generic;
using Domino;

namespace Domino
{
    public class Dominoes
    {

        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();

            int counter = 7;
            int indexB = 0;

                                

            DominoSort(indexB, dominoes, counter);
            Console.ReadKey();


            
        }



        private static void DominoSort(int indexB, List<Domino> dominoes, int counter)
        {

            while (counter > 0)
            {
                int j = 0;
                int i = j;
                int valueB = dominoes[indexB].GetValues()[1];
                int valueA = dominoes[i].GetValues()[0];
                int[] tempArray = dominoes[i].GetValues();

                for (i=0; i < 6; i++)
                {

                    if (valueA == valueB)
                    {
                        foreach (var item in tempArray)
                        {
                            Console.Write("[{0}]", item);
                        }
                        indexB = i;
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