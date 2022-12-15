using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları2022
{
    class ÇiftYönlüLinkedList
    {
        #region LİNKED LİST METOTLARI

        class Block
        {
            public int data;
            public Block next;
            public Block prev;
        }

        static void linkedRecursive(Block bl) //Linked Listleri Recursive Olarak Oluşturma
        {
            if (bl == null) return;

            Console.WriteLine(bl.data);

            linkedRecursive(bl.next);
            linkedRecursive(bl.prev); //Bu satır çiftli linked list yapar
        }

        static void yazdırList(Block temp)
        {
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        #endregion

        static void çiftliLinked() // BU KODLARI MAİN METODUNDA ÇALIŞTIRIN
        {
            #region ÇİFT YÖNLÜ LİNKED LİST

            #region Çiftli Linked List Elemanları Oluşturma
            /*
                        Block head = null; //baş
                         Block last = null; //son

                         for (int i = 0; i < 10; i++) //Linked List Oluşturma
                         {
                             Block temp = new Block();
                             temp.data = i;
                             temp.next = null;


                             if (head == null)
                             {
                                 head = temp;
                                 last = temp;
                             }

                             else
                             {
                                 last.next = temp;
                                 temp.prev = last;
                                 last = temp;
                             }
                             // yazdırList(temp);
                         }
            */

            #endregion

            #region Çiftli Linked List Elemanları Oluşturma ve Yazdırma //Daha Performanslı
            /*
            Block head = new Block();
            Block last = null;

            last = head;

            for (int i = 0; i < 10; i++)
            {
                Block temp = new Block();
                temp.data = i;
                temp.next = null;
                temp.prev = null;

                last.next = temp;
                temp.prev = last;
                last = temp;

                //yazdırList(temp); // Yazdırma

            }*/


            #endregion

            #region Çiftli Linked List Elemanları Yazdırma
            /*
            Block t = head;

            while (t != null || last!=null)
            {
                Console.WriteLine(t.data);
                Console.WriteLine(last.data);

                t = t.next;
                last = last.prev;
            }

            */
            #endregion

            #region Çiftli Linked List En Başa Eleman Ekleme
            /*
            Block ekle = new Block();
            ekle.data = 555;

            //Ekleme ---------------------
            ekle.next = head;
            ekle.prev = null;
            head.prev = ekle;
            head = ekle;
            //---------------------

            Block t = head;

            while (t!=null)
            {
                Console.WriteLine(t.data);
                t = t.next;
            }

            */
            #endregion

            #region Çiftli Linked List En Sona Eleman Ekleme
            /*
            Block ekle = new Block();
            ekle.data = 555;

            //Ekleme --------------------- 8 --> 9 --> 555 --> null
            ekle.next = null;
            ekle.prev = last;
            last.next = ekle;
            //---------------------

            Block t = head;

            while (t!=null)
            {
                Console.WriteLine(t.data);
                t = t.next;
            }
            */

            #endregion

            #region Çiftli Linked List Araya Eleman Ekleme
            /*
            Block ekle = new Block();
            ekle.data = 555;

            Block t = head;

            while (t != null)  // 1 --> 2 --> 3 --> 4 --> 5 --> 555 --> 6
            {
                Console.WriteLine(t.data);

                if (t.data == 5)
                {
                    ekle.next = t.next;
                    ekle.prev = t;

                    if(t.next!=null) t.next.prev = ekle; //eğer listede 1 eleman varsa 

                    t.next = ekle;

                    t=t.next; //eğer 5 değerini eklemeye çalışırsak hata verir o yüzden bu kod buraya da yazılır.
                }
                else
                    t = t.next;
            }
            */

            #endregion

            #region Çiftli Linked List En Baştan Eleman Sİlme
            /*
            Block t = head;

            t = t.next;
            t.next.prev = null;

            while (t != null)
            {
                Console.WriteLine(t.data);

                t = t.next;
            }*/

            #endregion

            #region Çiftli Linked List En Sondan Eleman Sİlme
            /*

            Block t = head;
            while (t != null) //Veya burası t.next!=null yapılabilir
            {
                Console.WriteLine(t.data); // 1 --> 2
                if (t.next.next==null)
                {
                    t = last;
                    last.prev = t;
                    last = t;
                }
                t = t.next;
            }
            */
            #endregion

            #region Çiftli Linked List Aradan Eleman Sİlme
            /*

            Block t = head;

            while (t != null) // 1 --> 2 -> 3 -> 4 -> 5 -> 6
            {
                Console.WriteLine(t.data);

                if (t.next.data == 5) //Çalışıyor ama NullReferenceException hatası fırlatıyor !! Hatasız çalışması için t.data==4 şeklinde yazılması lazım
                {
                    t.next = t.next.next;
                    t.next.next.prev = t;
                }


                t = t.next;
            }
            */
            #endregion

            #region Çiftli Linked List Dairesel Hale Getirme

            /*
             Block t = head;

             while (t.next!=null)
             {                
                 t = t.next;
             }

             t.next = head; 
             head.prev = t;


            Block yeni = head; // burada yeni değişkenine head değeri atanır = 0
                               // head.next= 0 olunca döngüden çıkmaz

            while (head.next!=yeni)
            {

                Console.WriteLine(head.data);
                head = head.next;

            }
            */

            #endregion

            #region Çiftli Linked List En Çok Tekrar Eden Veriyi Bulma İç İçe For // While Çözümü Daha İyi
            /*
            Block b1 = new Block();

            b1.data = 1;

            b1.next = new Block();
            b1.next.data = 4;

            b1.next.next = new Block();
            b1.next.next.data = 4;

            b1.next.next.next = new Block();
            b1.next.next.next.data = 3;


            Block t = b1;

            int[] dizi = new int[5];
            int sayac = 0;

            while (t != null)
            {
                dizi[sayac] = t.data;
                if (dizi[sayac] == t.data)
                {
                    Console.WriteLine("data:" + t.data);
                }
                t = t.next;
                sayac++;
            }

            int enÇ = 0;


            for (int i = 0; i < 4; i++)
            {
                sayac = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (dizi[i] == dizi[j])
                    {
                        sayac++;
                    }
                }
                if (enÇ < sayac)
                {
                    enÇ = sayac;
                }
            }


            Console.WriteLine(enÇ);

            */
            #endregion

            #region Çiftli Linked List En Çok Tekrar Eden Veriyi Bulma Tek While
            /*
            Block b1 = new Block();

            b1.data = 1;

            b1.next = new Block();
            b1.next.data = 4;

            b1.next.next = new Block();
            b1.next.next.data = 4;

            b1.next.next.next = new Block();
            b1.next.next.next.data = 4;


            Block t = b1;

            int[] dizi = new int[5]; // bu aralık en küçük block ile en büyük block değerleri arasında olması lazım
                                     // yani son block değeri 4 ise 5 tane elemanlı olmalı
                                     // burada en büyük block değerini 6 yaparsak İndexOutOfRange hatası veriri
            int enÇ = 0;

            while (t != null)
            {
                dizi[t.data]++;
                if (enÇ<dizi[t.data])
                {
                    enÇ = dizi[t.data];
                }
                t = t.next;
            }
            Console.WriteLine(enÇ);
            */
            #endregion

            #region Çiftli Linked List Herhangi Bir Elemandan Önce Eleman Silme // t.data==5 için çözemedim

            /*
            Block t = head;

            while (t.next != null) // 1 --> 2 --> 3 --> 4 --> 5 --> 6
            {
                if (t.next.data == 5)
                {
                    t.prev.prev.next = t;
                    t.prev = t.prev.prev;

                    t = t.next;
                }
                Console.WriteLine(t.data);

                t = t.next;

            }*/


            #endregion

            #region Çiftli Linked List Herhangi Bir Elemandan Önce Eleman Ekleme 
            /*
            Block t = head;
            Block ekle = new Block();
            ekle.data = 555;
            ekle.next = null;
            ekle.prev = null;

            while (t != null) // 1 --> 2 --> 3 --> 4 --> 555 --> 5 --> 6
            {
                if (t.data == 5 && t.prev.data ==4) // 4 ü kontrol etmemin sebebi ekleme işlemini yapınca t=555 oluyor t.next =5 oluyor bu yüzden sonsuz döngüye giriyor
                {                                   // ne yaptığımı anlamayan  && t.prev.data ==4 kısmın silip çalıştırsın
                    ekle.prev = t.prev;
                    t.prev.next = ekle;

                    t.prev = ekle;
                    ekle.next = t;

                    t = ekle;
                }

                Console.WriteLine(t.data);

                t = t.next;
            }
            */
            #endregion

            #region Çiftli Linked List Herhangi Bir İndisi Silme
            /*
            Block t = head;
            Block ekle = new Block();
            int sayac = 0; // silinecek indisi bulmak için

            while (t != null ) // 1 --> 2 --> 3 --> 4 --> 5 --> 6
            {

                if (sayac==4)
                {
                    t.prev.next = t.next;
                    t.next.prev = t.prev;

                    t = t.next;
                }

                Console.WriteLine(t.data);

                sayac++;
                t = t.next;

            }
            */
            #endregion

            #region Çiftli Linked List Çokça 5 ten Sondan İkinciyi Sil //Data sayısı biliniyorsa bu şekilde çözülebilir. Ama büyük bi ihtimalle eksik çözümdür, hocanın çözümüyle karşılaştırın
            /*
            Block b1 = new Block();

            b1.data = 1;

            b1.next = new Block();
            b1.next.data = 5;

            b1.next.next = new Block();
            b1.next.next.data = 3;

            b1.next.next.next = new Block();
            b1.next.next.next.data = 5;

            b1.next.next.next.next = new Block();
            b1.next.next.next.next.data = 5;


            Block t = b1;

            int sayac = 0;
            int sondanİkici=1;

            while (t != null) // 1 --> 5 --> 5 --> 5 --> 3
            {
                if (t.data==5)
                {
                    sayac++;
                }
                sondanİkici = sayac - 1; // sayac = 3 sondanİkinci = 2 

                if (sondanİkici==2)
                {
                    t.prev = t.next;
                    t.next.prev = t.prev;

                    t = t.next;
                }

                Console.WriteLine(t.data);
                t = t.next;
            }*/
            #endregion

            #region Çiftli Linked List Bir Dizi İçerisindeki Sıralı Olmayan Elemanları Sıralı Bir Şeklide Kopyalama
            /*
           int[] dizi = { 3, 6, 2, 1, 8, 9, 4 };

           for (int i = 0; i < 7; i++)
           {
               int enK = 0;
               Block sirali = new Block();
               for (int j = 0; j < 7; j++)
               {
                   for (int k = i; k < 7; k++)
                   {
                       if (dizi[j] > dizi[k])
                       {
                           enK = dizi[k];
                           dizi[k] = dizi[j];
                           dizi[j] = enK;
                       }
                   }
               }

               sirali.data = enK;

               if (head == null)
               {
                   head = sirali;
                   last = sirali;
               }
               else
               {
                   last.next = sirali;
                   sirali.prev = last;
                   last = sirali;
               }
               Console.WriteLine(sirali.data);
           }*/

            #endregion

            #region Çiftli Linked List Başka Bir Çifli Linked Liste Kopyalama 

            /*
            Block t = new Block();

            t = head;

            while (t .next!= null)
            {
                Block copy = new Block();
                copy.data = t.data;
                copy.next = null;
                copy.prev = null;

                if (head == null)
                {
                    head = copy;
                    last = copy;
                }
                else
                {
                    last.next = copy;
                    copy.prev = last;                    
                }
                Console.WriteLine(copy.data);

                t = t.next;

            }*/



            #endregion

            #region Çiftli veya Tekli Linked List Recursive Yazdırma
            /*
            for (int i = 0; i < 10; i++)
            {
                Block bl = new Block();
                bl.data = i;
                linkedRecursive(bl);
            }
            */
            #endregion

            #region Çiftli Linked List Tersten Kopyalama //Tersten yazdırıyor ama çok ufak problemi var
            /*
          Block t = head;
          Block ters = null;

          while (t!=null)
          {
              Block bl = new Block();
              bl.data = t.data;
              bl.next = ters;
              bl.prev = null;

              if (ters!=null)
              {
                  ters.prev = bl;
              }
              ters = bl;

              Console.WriteLine("ters");
              yazdırList(ters);

              t = t.next;

          }*/


            #endregion

            #region Çiftli Linked List Düz Kopyalama
            /*
            Block t = head;
            Block first = null; // bunu kullanmayıp if(head==null) dersek sonsuz döngüye girer

            while (t != null)
            {
                Block kopya = new Block();
                kopya.data = t.data;
                kopya.next = null;
                kopya.prev = null;

                if (first == null)
                {
                    first = kopya;
                    last = kopya;
                }
                else
                {
                    kopya.prev = last;
                    last.next = kopya;
                    last = kopya;

                }
                yazdırList(kopya);
                t = t.next;
            }
            */
            #endregion


            #endregion
        }



    }
}
