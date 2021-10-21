using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class Sort
    {
        public int[] Tabela { get; set; }
        public Sort(int[] Tabela)
        {
            this.Tabela = Tabela;
        }

        public Sort()
        {
        }

        public virtual void ToSort() { }
        
    }
}
