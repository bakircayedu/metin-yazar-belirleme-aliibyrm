using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
   public class HeapSort
    {
        public int[] dizi { get; set; }
        public HeapSort(int[] dizi)
        {
            this.dizi = dizi;
        }
        public int[] Sort()
        {
            MaxHeap h = new MaxHeap(dizi.Length);
            int[] sorted = new int[dizi.Length];
            foreach (int item in dizi)
            {
                h.Add(item);
            }
            int i = 0;
            while (!h.IsEmpty())
                sorted[i++] = h.RemoveMax();
            return sorted;
        }
    }
}
