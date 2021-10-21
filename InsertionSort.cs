using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorting_Algorithms
{
    class InsertionSort : Sort
    {
        
        public InsertionSort(int[] Tabela) : base(Tabela)
        {
            
        }

        public override void ToSort()
        {
            var watch = Stopwatch.StartNew();
            for (int i = 0; i < Tabela.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (Tabela[j - 1] > Tabela[j])
                    {
                        int temp = Tabela[j - 1];
                        Tabela[j - 1] = Tabela[j];
                        Tabela[j] = temp;
                    }
                }
            }
            watch.Stop();
            Console.WriteLine("Koha e ekzekutimit me ane te Insertion Sort eshte: " + watch.Elapsed);
        }
    }
}
