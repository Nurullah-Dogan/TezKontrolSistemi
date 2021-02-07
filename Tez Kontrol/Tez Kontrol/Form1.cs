using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Tez_Kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dosya_sec_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Word Dosyası |*.docx";
            file.ShowDialog();
            string Dosyayolu = file.FileName;
            Dosyayolu = Dosyayolu.Replace("\\", "/");
            dosya_yolu_label.Text = Dosyayolu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox10.Items.Clear();

            if (dosya_yolu_label.Text != "Dosya Seçilmedi")
            {
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                object miss = System.Reflection.Missing.Value;
                object path = dosya_yolu_label.Text;
                object readOnly = true;
                Microsoft.Office.Interop.Word.Document docs = word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss);
                int resimsayisi = 0, tablosayisi = 0;
                int onsozparagraf = 0, icindekilerparagraf = 0, beyanparagraf = 0, kaynaklarparagraf=0, eklerparagraf=docs.Paragraphs.Count;
                int basliksayisi = -1;
                string metin = "";
        
                //int sekilsayisi = docs.InlineShapes.Count;

                for (int i = 0; i < docs.Paragraphs.Count; i++)
                {
                    metin = docs.Paragraphs[i + 1].Range.Text.ToString();                    
                    char[] karakter = metin.ToCharArray();

                    progressBar1.Value =((i+1)*100)/docs.Paragraphs.Count;

                    if (docs.Paragraphs[i + 1].Range.Font.Size > 12 && docs.Paragraphs[i + 1].Range.Font.Bold == -1 && docs.Paragraphs[i + 1].Range.Text.ToString() != "\r" && docs.Paragraphs[i + 1].Range.Text.ToString() != "\n" && Char.IsLetter(karakter[0 | 1]) == true ) //Başlıkları bulup listboxa ekleme
                    {
                        if (metin.ToLower().Trim() == "Beyan".ToLower())
                            beyanparagraf = i + 1;
                        if (metin.ToLower().Trim() == "kaynaklar".ToLower())
                            kaynaklarparagraf = i + 1;
                        if (metin.ToLower().Trim() == "ekler".ToLower())
                            eklerparagraf = i + 1;

                        if (beyanparagraf>0)
                        {
                            listBox1.Items.Add(metin.Trim());
                            basliksayisi++;
                            if (listBox1.Items[basliksayisi].ToString().ToLower().Contains("önsöz".ToLower())) { onsozparagraf = i + 1; }
                            if (listBox1.Items[basliksayisi].ToString().ToLower().Contains("içindekiler".ToLower())) { icindekilerparagraf = i + 1; }
                        }       
                    }
                    if (beyanparagraf > 0 && metin.Length > 2 && docs.Paragraphs[i + 1].Range.Font.Size < 13 && docs.Paragraphs[i + 1].Range.Font.Bold != -1 && docs.Paragraphs[i + 1].Range.Font.Italic != -1 && docs.Paragraphs[i + 1].Range.Text.ToString() != "\r" && docs.Paragraphs[i + 1].Range.Text.ToString() != "\n" && Char.IsLetter(karakter[0 | 1]) == true) // metinleri listboxa ekleme
                    {              
                        if(kaynaklarparagraf == 0)                            
                            listBox2.Items.Add(metin.Trim());
                        else
                            if (eklerparagraf == docs.Paragraphs.Count && metin.Length>55)
                            listBox8.Items.Add(metin.Trim());
                    }
                    if (beyanparagraf > 0 && kaynaklarparagraf==0 && metin.Length> 7 && docs.Paragraphs[i + 1].Range.Font.Size < 11 && (metin.Substring(0,5)=="Şekil" || metin.Substring(0, 5) == "Tablo") && Char.IsNumber(karakter[6]) == true) //şekil ve tablo yazılarını bulup listboxa ekleme
                    {
                        listBox3.Items.Add(metin.Trim());  
                    }
                   
                }
                label13.Text = "Kaynak Sayısı: "+listBox8.Items.Count.ToString();
                label6.Text = "Başlık Sayısı: " + listBox1.Items.Count.ToString();


                //------------Önsöz ilk paragrafta Teşekkür ibaresi var mı?-------------------------    

                for (int i = onsozparagraf + 1; i < onsozparagraf + 3; i++)
                {

                    listBox4.Items.Add(docs.Paragraphs[i + 1].Range.Text.ToString());

                }

                bool tesekkurvarmi = false;


                for (int i = 0; i < listBox4.Items.Count; i++)
                {
                    if (listBox4.Items[i].ToString().ToLower().Contains("teşekkür".ToLower()))
                    {
                        listBox4.SetSelected(i, true);
                        tesekkurvarmi = true;
                        break;
                    }
                }

                if (tesekkurvarmi == true)
                    label8.Text = "Teşekkür ibaresi var";
                else
                    label8.Text = "Teşekkür ibaresi yok";

                // ----------------------------------------------



                // --------------- Şekil, tablo sayısı  ve atıf yapılmayan şekil, tablolar------------------                

                for (int j = 0; j < listBox3.Items.Count; j++)
                {
                    if (listBox3.Items[j].ToString().ToLower().Contains("Şekil".ToLower()))
                    {
                        resimsayisi++;
                        int atifyapilmayansekil = 0;
                        string cumle3 = listBox3.Items[j].ToString();
                        string sekiladi;
                        if (cumle3.Substring(9, 1)==".")
                            sekiladi = cumle3.Substring(0, 9);
                        else sekiladi = cumle3.Substring(0, 10);

                        foreach (string eleman in listBox2.Items)
                        {
                            if (eleman.ToString().ToLower().Contains(sekiladi.ToLower()))
                            {
                                atifyapilmayansekil++;                                
                            }
                        }
                        if(atifyapilmayansekil < 2)
                            listBox9.Items.Add(sekiladi);
                    }
                    if (listBox3.Items[j].ToString().ToLower().Contains("Tablo".ToLower()))
                    {
                        tablosayisi++;
                        int atifyapilmayantablo = 0;
                        string cumle3 = listBox3.Items[j].ToString();
                        string tabloadi;
                        if (cumle3.Substring(9, 1) == ".")
                            tabloadi = cumle3.Substring(0, 9);
                        else tabloadi = cumle3.Substring(0, 10);

                        foreach (string eleman in listBox2.Items)
                        {
                            if (eleman.ToString().ToLower().Contains(tabloadi.ToLower()))
                            {
                                atifyapilmayantablo++;
                            }
                        }
                        if (atifyapilmayantablo < 2)
                            listBox10.Items.Add(tabloadi);
                    }
                }

                label7.Text = "Şekil Sayısı: " + resimsayisi.ToString();
                label12.Text = "Tablo Sayısı: " + tablosayisi.ToString();

                // ----------------------------------------------



                //------------Çift tırnak cümle sayısı ve 50'den fazla kelime sayısı -------------------------                
                int tirnaksayac = 0, tirbaslangic = 0;
                string tirnakcumle = "";
                
                foreach (string eleman in listBox2.Items)
                {
                    
                    for (int i = 0; i < eleman.Length; i++)
                    {
                        
                        if (eleman[i] == '“')
                        { tirnaksayac++; tirbaslangic = i; }
                        if (eleman[i] == '”')
                        {
                            for (int j = tirbaslangic; j < i+1; j++)
                            {
                                tirnakcumle += eleman[j];
                            }
                            listBox5.Items.Add(tirnakcumle);
                            string[] dogrudanalinti = tirnakcumle.Split(' ');
                            if(dogrudanalinti.Length > 50)
                            {
                                listBox6.Items.Add(tirnakcumle);
                            }
                            tirnakcumle = "";
                        }

                    }                    
                }
                label10.Text = "Cümle Sayısı: " + tirnaksayac.ToString();
                label11.Text = "Alıntı Sayısı: " + listBox6.Items.Count.ToString();
                // ----------------------------------------------


                // --------------- Büyük küçük harf kontrolü ------------------
                int buyukharfhatasi = 0;
                char harf=' ';
                
                for (int j = 0; j < listBox2.Items.Count; j++)
                {
                    string cumlee = listBox2.Items[j].ToString();
                    string[] cumleler2 = cumlee.Split('.', '“','?','!');       

                    for (int k = 1; k < cumleler2.Length; k++)
                    {
                        cumlee= cumleler2[k].Trim();
                        if(String.IsNullOrWhiteSpace(cumlee)==false)
                            harf = Convert.ToChar(cumlee.Substring(0, 1));
                        
                         if (char.IsLower(harf))
                         {
                             buyukharfhatasi++;
                             listBox7.Items.Add(cumlee);
                         }                        
                    }
                }
                
                label14.Text = "Büyük-Küçük harf hatası: " + buyukharfhatasi.ToString();

                // ----------------------------------------------

                MessageBox.Show("Tez kontrol işlemi tamamlandı.");
                docs.Close();
                word.Quit();
            }            
        }
    }
}
