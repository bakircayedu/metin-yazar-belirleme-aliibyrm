using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class HeapTree
    {
        public int[] dizi;
        public string[] kelimeler;
        public int sizeOfTree;
        // Bir kurucu oluştur  
        public HeapTree(int size)
        {
            // Size+1 ekliyoruz, çünkü dizi indeksi 0 boş olacak.  
            dizi = new int[size + 1];
            kelimeler = new string[size + 1];
            this.sizeOfTree = 0;
            Console.WriteLine("Boş yığın başarıyla oluşturuldu");
        }

        public int PeekOfHeap()
        {
            if (sizeOfTree == 0)
                return 0;
            else
                return dizi[1] + Convert.ToInt32(kelimeler[1]);
        }
        public int SizeOfHeap()
        {
            return sizeOfTree;
        }

        public void InsertElementInHeap(string kelime, int kelimeSayisi)
        {

            if (SizeOfHeap() < 0)
            {
                Console.WriteLine("Tree is empty");
            }
            else
            {

                dizi[sizeOfTree + 1] = kelimeSayisi;
                kelimeler[sizeOfTree + 1] = kelime;
                sizeOfTree++;
                HeapifyBottomToTop(sizeOfTree);

                levelOrder();
            }

        }
        public void HeapifyBottomToTop(int index)
        {
            int parent = index / 2;

            if (index <= 1)
            {
                return;
            }

            if ((dizi[index] < dizi[parent]))
            {
                int tmp = dizi[index];
                string satir = kelimeler[index];
                kelimeler[index] = kelimeler[parent];
                kelimeler[parent] = satir;
                dizi[index] = dizi[parent];
                dizi[parent] = tmp;
            }
            HeapifyBottomToTop(parent);
        }

        public string levelOrder()
        {
            string sonuc = "";
            for (int i = 1; i <= sizeOfTree; i++)
            {
                sonuc += kelimeler[i] + " " + dizi[i].ToString();

            }
            return sonuc;
        }

        public int extractHeadOfHeap()
        {
            if (sizeOfTree == 0)
            {

                return -1;
            }
            else
            {

                int extractedValue = dizi[1];
                dizi[1] = dizi[sizeOfTree];
                sizeOfTree--;
                HeapifyTopToBottom(1);

                levelOrder();
                return extractedValue;
            }
        }

        public void HeapifyTopToBottom(int index)
        {
            int left = index * 2;
            int right = (index * 2) + 1;
            int smallestChild = 0;

            if (sizeOfTree < left)
            { 
                return;
            }
            else if (sizeOfTree == left)
            {   
                if (dizi[index] > dizi[left])
                {
                    int tmp = dizi[index];
                    dizi[index] = dizi[left];
                    dizi[left] = tmp;
                }
                return;
            }
            else
            { 
                if (dizi[left] < dizi[right])
                { 
                    smallestChild = left;
                }
                else
                {
                    smallestChild = right;
                }
                if (dizi[index] > dizi[smallestChild])
                { 
                    int tmp = dizi[index];
                    dizi[index] = dizi[smallestChild];
                    dizi[smallestChild] = tmp;
                }
            }
            HeapifyTopToBottom(smallestChild);

        }
    }
}
