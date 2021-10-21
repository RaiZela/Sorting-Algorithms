using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorting_Algorithms
{
    class QuickSort : Sort
    {
        public int Left { get; set; }
        public int Right { get; set; }
        public QuickSort(int[] Tabela) : base(Tabela)
        {

        }

        public int Partition(int Left, int Right)
        {
            int pivot;
            pivot = Tabela[Left];
            while (true)
            {
                while (Tabela[Left] < pivot)
                {
                    Left++;
                }
                while (Tabela[Right] > pivot)
                {
                    Right--;
                }
                if (Left < Right)
                {
                    int temp = Tabela[Right];
                    Tabela[Right] = Tabela[Left];
                    Tabela[Left] = temp;
                }
                else
                {
                    return Right;
                }
            }
        }
        public void QuickSorting(int Left, int Right)
        {

            int pivot;
            if (Left < Right)
            {
                pivot = Partition(Left, Right);
                if (pivot > 1)
                {
                    QuickSorting(Left, pivot - 1);
                }
                if (pivot + 1 < Right)
                {
                    QuickSorting(pivot + 1, Right);
                }
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < Tabela.Length; i++)
            {
                Console.WriteLine(Tabela[i]);
            }
        }

        public override void ToSort()
        {
            var watch = Stopwatch.StartNew();
            QuickSorting(0, Tabela.Length - 1);
            watch.Stop();
            Console.WriteLine("Koha e ekzekutimit me ane te QuickSort eshte: " + watch.Elapsed);
        }
    }
}
