using System;
using Sorting_Algorithms;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int row = (int)(rand.Next(20));
            Sort tabelaRradhitur;

            var Tabela = new int[row][];

            for (int i = 0; i < Tabela.Length; i++)
            {
                int column = (int)(rand.Next(100000));
                Tabela[i] = new int[column];

                for (int j = 0; j < Tabela[i].Length; j++)
                {
                    Tabela[i][j] = (int)(rand.Next(100));
                }
            }
            for (int j = 0; j < 20; j++)
            {
                for (int i = 0; i < Tabela.Length; i++)
                {


                    if (Tabela[i].Length < 50)
                    {
                        tabelaRradhitur = new InsertionSort(Tabela[i]);
                        tabelaRradhitur.ToSort();
                    }

                    if (50 < Tabela[i].Length && Tabela[i].Length <= 500)
                    {
                        tabelaRradhitur = new BubbleSort(Tabela[i]);
                        tabelaRradhitur.ToSort();
                    }

                    if (500 < Tabela[i].Length && Tabela[i].Length <= 5000)
                    {
                        tabelaRradhitur = new SelectionSorting(Tabela[i]);
                        tabelaRradhitur.ToSort();
                    }

                    if (5000 < Tabela[i].Length && Tabela[i].Length <= 50000)
                    {
                        tabelaRradhitur = new MergeSorting(Tabela[i]);
                        tabelaRradhitur.ToSort();
                    }

                    if (50000 < Tabela[i].Length && Tabela[i].Length <= 500000)
                    {
                        tabelaRradhitur = new QuickSort(Tabela[i]);
                        tabelaRradhitur.ToSort();
                    }
                }
            }

        }

    }
}

