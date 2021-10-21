using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorting_Algorithms
{
    class SelectionSorting : Sort
    {
        public SelectionSorting(int[] Tabela) : base(Tabela)
        {
            
        }

        public override void ToSort()
        {
            var watch = Stopwatch.StartNew();
            int n = Tabela.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (Tabela[j] < Tabela[min_idx])
                        min_idx = j;

                int temp = Tabela[min_idx];
                Tabela[min_idx] = Tabela[i];
                Tabela[i] = temp;
            }
            watch.Stop();
            Console.WriteLine("Koha e ekzekutimit me ane te selection sort eshte: " + watch.Elapsed);
        }
       
    }
}

