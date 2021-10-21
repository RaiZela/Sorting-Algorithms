using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorting_Algorithms
{
    class MergeSorting : Sort
    {
        public int Left { get; set; }
        public int Middle { get; set; }
        public int Right { get; set; }

        public MergeSorting(int[] Tabela) : base(Tabela)

        {

        }

        private void MergeAlgorithm(int leftIndex, int middle, int rightIndex)
        {

            int[] temp = new int[rightIndex - leftIndex + 1];
            int i = leftIndex, j = middle + 1, k = 0;

            while (i <= middle && j <= rightIndex)
            {
                if (this.Tabela[i] <= this.Tabela[j])
                {
                    temp[k] = this.Tabela[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = this.Tabela[j];
                    k++; j++;
                }
            }
            //first interval
            while (i <= middle)
            {
                temp[k] = this.Tabela[i];
                k++; i++;
            }
            //second interval
            while (j <= rightIndex)
            {
                temp[k] = this.Tabela[j];
                k++; j++;
            }
            //copy temp to original
            for (i = leftIndex; i <= rightIndex; i++)
            {
                this.Tabela[i] = temp[i - leftIndex];
            }
        }
        private void SortMerge(int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middle = (leftIndex + rightIndex) / 2;

                SortMerge(leftIndex, middle);
                SortMerge(middle + 1, rightIndex);
                MergeAlgorithm(leftIndex, middle, rightIndex);
            }
        }
        public override void ToSort()
        {


            var watch = Stopwatch.StartNew();
            SortMerge(0, this.Tabela.Length - 1);
            watch.Stop();
            Console.WriteLine($"Koha e ekzekutimit me ane te MergeSort eshte: {watch.Elapsed}" );


        }
    }      
}
