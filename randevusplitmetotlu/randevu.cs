using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace randevusplitmetotlu
{
    class randevu
    {
        public static string kimindosyasıbuu = @"bubenimdosyammm.txt";

        public static void ekle(string satir)
        {
            StreamWriter yazz = new StreamWriter(kimindosyasıbuu, true);
            yazz.WriteLine(satir);
            yazz.Close();
        }


        public static string listele()
        {
            StreamReader okuu = new StreamReader(kimindosyasıbuu);
            string içi = okuu.ReadToEnd();
            while (okuu.EndOfStream==false)
            {
                içi += okuu.ReadLine();
            }
            okuu.Close();
            return içi;
        }


        public static bool varmıdır(string bolum,string tarih,string saat)
        {
            StreamReader oku = new StreamReader(kimindosyasıbuu);
            bool sonuc = false;
            while (oku.EndOfStream==false)
            {
                string satir = oku.ReadLine();
                string[] parcala = satir.Split('*');
                if ((parcala[3] == bolum) && (parcala[4] == tarih) && (parcala[5] == saat))
                sonuc = true;
            }
            oku.Close();
            return sonuc;
        }


        public static string Ogununrandevuları(string arananbolum,string aranantarih)
        {
            StreamReader oku = new StreamReader(kimindosyasıbuu);
            string isatir="";           
            while (oku.EndOfStream==false)
            {
                string satir = oku.ReadLine();
                string[] bol = satir.Split('*');
                if ((bol[3] == arananbolum) && (bol[4] == aranantarih))
                {
                    isatir += satir;
                }    
                
            }                                      
            oku.Close();
            return isatir;
                             
        }



    }
}
