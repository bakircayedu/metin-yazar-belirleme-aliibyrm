using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Odev
{
    public partial class Form1 : Form
    {
        private object butonu;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnDosyaAl_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(file.FileName);
                if (fi.Exists)
                {
                    System.Diagnostics.Process.Start(file.FileName);
                }
                else 
                {
                    //Hata
                }
                string yol = file.FileName.ToString();
                MessageBox.Show(Path.GetDirectoryName(yol));
            }
        }

        int Konum = -1;
        private void btnStackeOku_Click(object sender, EventArgs e)
        {
            StackUsingLinkedList dosyaStack = new StackUsingLinkedList();
            StreamReader sr = new StreamReader("C: \\Users\\aliba\\OneDrive\\Masaüstü\\Ödev Gereksinimler.txt");
            string satir = "";
            float cumleSayisi = 0;
            float ortKelime = 0;
            float toplamKelimeler = 0;

            while (true)
            {
                
                satir = sr.ReadLine();
                if (satir == null)
                {
                    break;
                }
            
                dosyaStack.push(satir);
                cumleSayisi = cumleSayisi + 1;
                MessageBox.Show(dosyaStack.peek().ToString());
                string metin;

                metin = satir;
                string[] kelimeler = metin.Split(' ');
                toplamKelimeler += kelimeler.Length;
                lstBoxBilgi.Items.Add("\nCümle Sayısı:" + cumleSayisi.ToString() + "  Kelime sayisi: " + kelimeler.Length);
            }
            ortKelime = toplamKelimeler / cumleSayisi;
            lstBoxBilgi.Items.Add("Ortalama kelime sayısı: " + ortKelime.ToString());
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int metinTekrarSayisi = 0;
            HeapTree agac = new HeapTree(100);
            KelimeStack kelime = new KelimeStack();
            StackUsingLinkedList dosya = new StackUsingLinkedList();
            StreamReader sr = new StreamReader("C: \\Users\\aliba\\OneDrive\\Masaüstü\\Ödev Gereksinimler.txt");

            string aranacakKelime = txtBoxKelimeAra.Text;
            string metin= " ";
            int cumleSayisi = 0;
            
            while (true)
            {
                
                int index = 0, tekrarSayisi = 0, i = 0;

                metin = sr.ReadLine();
                if (metin == null)
                {
                    break;
                }

                dosya.push(metin);
                cumleSayisi++;
                string[] kelimeler=metin.Split(' ');

                for (i = 0; i < kelimeler.Length; i++)
                {
                    if (aranacakKelime == kelimeler[i])
                    {
                        tekrarSayisi++;
                        index = i;
                        i++;

                        MessageBox.Show(cumleSayisi.ToString() + "-Cümle :  " + dosya.peek().ToString() + "\nAranan Kelime :  "
                        + aranacakKelime + "\nCümlede kaçıncı index :  " + index.ToString() +
                        "\nCümlede kaçıncı sırada :  " + i.ToString() + "\nCümlede kullanım sıklığı :  " + tekrarSayisi.ToString()); 
                        continue;   
                    }
                }

                metinTekrarSayisi += tekrarSayisi;
            }
            kelime.push(aranacakKelime, metinTekrarSayisi);
            
            MessageBox.Show("Kelime Stacki dönen değer:\n" + kelime.peek());
            agac.InsertElementInHeap(aranacakKelime, metinTekrarSayisi);
            MessageBox.Show("geldi:  " + agac.levelOrder());
            MessageBox.Show("\n Metinde kullanım sıklığı :  " + metinTekrarSayisi.ToString());
        }

        private void btnAgacaAktar_Click(object sender, EventArgs e)
        {
            StackUsingLinkedList dosyaStack = new StackUsingLinkedList();
            StreamReader sr = new StreamReader("C: \\Users\\aliba\\OneDrive\\Masaüstü\\Ödev Gereksinimler.txt");
            HeapTree kelimeAgaci = new HeapTree(100);
            KelimeStack KelimelerStack = new KelimeStack();
            int cumleSayisi = 0, toplamKelime = 0, index = 0;
            string[] metin = new string[1000];
            string kelimeAramasi = "";
            string satir;
            while (true)
            {
                satir = sr.ReadLine();
                if (satir == null)
                {
                    for (int i = 0; i < toplamKelime; i++)
                    {
                        int metindeArananSayisi = 0, say = 0;
                        kelimeAramasi = metin[i];
                        for (int j = 0; j < toplamKelime; j++)
                        {
                            if (kelimeAramasi == metin[j])
                            {
                                say++;
                            }
                        }
                        metindeArananSayisi += say;
                        kelimeAgaci.InsertElementInHeap(kelimeAramasi, metindeArananSayisi);
                        MessageBox.Show("geldi :  " + kelimeAgaci.levelOrder());
                    }
                    break;
                }
                dosyaStack.push(satir);
                cumleSayisi++;
                string[] kelimeler = satir.Split(' ');
                toplamKelime += kelimeler.Length;

                foreach (var kelime in kelimeler)
                {
                    if (kelime == "")
                        break;
                    metin[index] += kelime;
                    index++;
                }
            }
        }
    }
}