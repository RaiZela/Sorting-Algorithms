using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorting_Algorithms
{
    class BubbleSort : Sort
    {

        public BubbleSort(int[] Tabela) : base(Tabela)
        {

        }

        public override void ToSort()
        {
            var watch = Stopwatch.StartNew();
            int count = 0;
            for (int j = 0; j < Tabela.Length; j++)
            {
                for (int i = 0; i < Tabela.Length - 1; i++)
                {
                    if (Tabela[i] > Tabela[i + 1])
                    {
                        int temp = Tabela[i + 1];
                        Tabela[i + 1] = Tabela[i];
                        Tabela[i] = temp;
                        count++;
                    }
                }
            }
            watch.Stop();
            Console.WriteLine("Koha e ekzekutimit me ane te BubbleSort eshte: " + watch.Elapsed);
        }
    }
}
