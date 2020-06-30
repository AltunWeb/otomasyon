using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Kutuphane_projesi
{
    class Kitap
    {
        public void kitap_ekle(string kitap_ismi)
        {
            FileStream fs = new FileStream("kitap_listesi.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(kitap_ismi);
            sw.Close();
        }

        public void kitap_goruntule()
        {
            FileStream fs = new FileStream("kitap_listesi.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string yazi = sr.ReadLine();
            while (yazi != null)
            {
                Console.WriteLine(yazi);
                yazi = sr.ReadLine();
            }
            sr.Close();

        }
        public void odunc_kitap_listesi()
        {
            FileStream fs = new FileStream("odunc_listesi.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string yazi = sr.ReadLine();
            while (yazi != null)
            {
                Console.WriteLine(yazi);
                yazi = sr.ReadLine();
            }
            sr.Close();

        }
        public void odunc_kitap(string kitap_ismi)
        {
            Boolean bulunma = false;
            FileStream f1 = new FileStream("kitap_listesi.txt", FileMode.OpenOrCreate, FileAccess.Read);
            FileStream fs = new FileStream("odunc_listesi.txt", FileMode.OpenOrCreate, FileAccess.Write);

            StreamReader kutuphane = new StreamReader(f1);
            StreamWriter odunc_yaz = new StreamWriter(fs);


            Console.WriteLine("******Kutuphanede bulunan kitaplar***** \n");
            string yazi2 = kutuphane.ReadLine();
            while (yazi2 != null)
            {
                Console.WriteLine("*" + yazi2);
                if (kitap_ismi == yazi2)
                {
                    odunc_yaz.WriteLine(yazi2);
                    bulunma = true;
                }



                yazi2 = kutuphane.ReadLine();
            }
            kutuphane.Close();
            if (bulunma == true)
                Console.WriteLine("Kitap bulundu ve odunc verildi.");
            else
                Console.WriteLine("Kitap bulunamadı listede bulunan bir kitap giriniz!!!");
        }
    }
}
