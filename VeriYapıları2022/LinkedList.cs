using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları2022
{


    class LinkedList
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


        #region TEK YÖNLÜ LİNKED LİST

        #region Tekli Linked List OLuşturma
        /* Block head = null; //baş
         Block last = null; //son
         for (int i = 0; i < 10; i++) //Linked List Oluşturma
         {
             Block temp = new Block();
             temp.data = i;
             temp.next = null;

             if (head == null) head = temp;

             else last.next = temp;

             last = temp;
         }*/
        #endregion

        #region Tekli Linked List Yazdırma
        /*


        Block tt = head; //listeyi yazdırma

        while (tt!=null)
        {
            Console.Write(tt.data+"->");
            tt = tt.next;
        }*/
        #endregion

        #region Tekli Linked List En Başa Eleman Ekleme
        /*
        Block first = new Block(); //Eklenecek Eleman
        first.data = 10;
        first.next = null;

        if (head == null) //Liste varmı yoksa ilke elemanlar oluşturuldu
        {
            first.next = null;
            head = first;
            last = first;
        }
        else //first ü en başa ekle
        {
            first.next = head;
            head = first;
        }


        Block t = head;

        while (t != null)
        {
            Console.WriteLine(t.data);
            t = t.next;
        }

        */
        #endregion

        #region Tekli Linked List En Sona Eleman Ekleme
        /*
        Block end = new Block();
        end.data = 10;
        end.next = null;

        if (head==null)
        {
            end.next = null;
            head = end;
            last = end;
        }
        else
        {
            end.next = null;
            last.next = end;
            last = end;

        }

        Block t = head;

        while (t != null)
        {
            Console.Write(t.data+"->");
            t = t.next;
        }
        */

        #endregion

        #region Tekli Linked List Araya Eleman Ekleme
        /*
        Block eleman = new Block(); // 1 -> 2 --> 77 -> 3
        eleman.data = 7;
        eleman.next = null;

        Block t = head;

        while (t != null)
        {
            if (t.data == 7)
            {
                eleman.next = t.next;
                t.next = eleman;
            }
            Console.WriteLine(t.data);
            t = t.next;
        }
        */
        #endregion

        #region Tekli Linked List Aradan Eleman Silme

        /*
        Block b1 = new Block();

        b1.data = 1;

        b1.next = new Block();
        b1.next.data = 3;

        b1.next.next = new Block();
        b1.next.next.data = 3;

        b1.next.next.next = new Block();
        b1.next.next.next.data = 3;

        b1.next.next.next.next = new Block();
        b1.next.next.next.next.data = 2;

        Block t = b1;
        while (t.next != null)
        {

            if (t.next.data == 3) //
            {
                t.next = t.next.next;
            }

            Console.WriteLine(t.data);
            t = t.next;
        }
        */

        #endregion

        #region Tekli Linked List Baştan Eleman Silme

        /*
         Block t = head;

         while (t.next != null)
         {
             if (t.data == 0) //0-> 1 -> 2 -> 3 -> 2
             {
                 t.data = t.next.data;
             }

             t = t.next;
             Console.WriteLine(t.data);
         }
*/
        #endregion

        #region Tekli Linked List Sondan Eleman Silme
        /*
        Block t = head;
        Block temp2 = head;
        while (t.next.next != null) // 6 -> 7 -> 8 -> 9
        {

            t = t.next;

            Console.WriteLine(t.data);

        }
        */
        #endregion

        #region Tekli Linked List En Büyük Elemanını ve En Büyük 2. Elemanını Bulma
        /*
        int enB = 0;
        int enB2 = 0;
        Block t2 = head;

        while (t2 != null)
        {
            if (enB < t2.data)
            {
                enB2 = enB;
                enB2 = t2.data; //en büyük elemanını bul

            }
            else if (enB < t2.data && t2.data != enB)
            {
                enB2 = t2.data; //en büyük 2. elemanını bul
            }

            Console.WriteLine(t2.data);
            t2 = t2.next;
        }
        Console.WriteLine("En B:{0}", enB);
        Console.WriteLine("En B2:{0}", enB2);
        */
        #endregion

        #region Tekli Linked Listi Diziye Ters ve Düz Kopyalama Kopyalama
        /*
        Block t2 = head;
        int[] dizi = new int[10];
        int[] dizi2 = new int[10];
        int adet = 0;
        int adet2 = 9;

        // AYNI ANDA ÇALIŞIRLARSA SIKINTI ÇIKAR

        // while (t2!=null) //DÜZ KOPYALAMA
        //{
        //    dizi[adet] = t2.data;
        //    adet++;
        //    t2 = t2.next;
        // }

        while (t2!=null) //TERS KOPYALAMA
        {
            dizi2[adet2] = t2.data;
            adet2--;
            t2 = t2.next;
        }

        Console.WriteLine("Dizi 1 Yazdırma");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(dizi[i]); 
        }
        Console.WriteLine("Dizi 2 Yazdırma");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine( dizi2[i]);
        }*/
        #endregion

        #region Tekli Linked Listi Tekli Linked Liste Kopyalama //DEVAM ET
        /*
        Block t = head;

        Block first = null;

        while (head!=null) //Asıl Liste
        {
            Console.WriteLine(t.data);
            t = t.next;
        }

        */
        #endregion

        #region Dizinin Elemanlarını Linked Liste Sıralı Bir Şekilde Yazdırma

        /*
        int[] dizi = { 13, 32, 45, 11, 20 };

        Block copy = null;
        Block son = null;

        for (int i = 0; i < dizi.Length; i++)
        {
            int enK =0;
            Block bl = new Block(); //kopya olan list

            for (int j = 0; j < dizi.Length; j++)
            {
                for (int k = i; k < dizi.Length; k++)
                {
                    if (dizi[j]>=dizi[k])
                    {
                        enK = dizi[k];
                        dizi[k] = dizi[j];
                        dizi[j] = enK;
                    }
                }
            }

            bl.data = enK;

            if (copy==null)
            {
                copy = bl;
                son = bl;
            }
            else
            {
                son.next = bl;
                son = bl;
            }

            Console.WriteLine(bl.data);

        }


        */
        #endregion

        #region Tekli Linked List İndise Göre Eleman Silme 
        /*
                    Block t = head;
                    int indis = 1; 

                    while (t!=null)
                    {
                        Console.WriteLine(t.data);
                        indis++;
                        if (indis==4) //4. elemanını sil  !!DATA değeri 4 olan DEĞİL
                        {
                            t.next = t.next.next;
                        }
                        t = t.next;
                    }
        */


        #endregion

        #region Tekli Linked List İndise Göre Araya Eleman Ekleme
        /*
        Block t = head;
        Block ekle = new Block();
        ekle.data = 555;
        ekle.next = null;
        int indis = 1;

        while (t != null)
        {
            Console.WriteLine(t.data);
            indis++;
            if (indis == 4) //3. eleman olarak ekle  !!DATA değeri 4 olandan sonra DEĞİL
            {
                ekle.next = t.next;
                t.next = ekle;
            }

            t = t.next;
        }
        */
        #endregion

        #region  Tekli Linked List İndise Göre Başa Eleman Ekleme
        /*  Block t = head;
          Block ekle = new Block();
          ekle.data = 555;
          ekle.next = null;
          int indis = 1;

          if (indis == 1) //en başa eleman ekle
          {
              ekle.next = t;
              t = ekle;
          }
          while (t != null)
          {
              Console.WriteLine(t.data);
              indis++;
              t = t.next;
          }
          */
        #endregion

        #region Tekli Linked List İndise Göre Sona Eleman Ekleme
        /*
         Block t = head;
         Block ekle = new Block();
         ekle.data = 555;
         ekle.next = null;
         int indis = 1;


         while (t != null)
         {
             Console.WriteLine(t.data);
             indis++;
             if (indis == 10) //Sona Ekle
             {
                 ekle.next = null;
                 t.next.next = ekle;
                 //last.next = ekle;

             }
             t = t.next;
         }
        */
        #endregion

        #region Tekli Linked List Çift Sayıları Yazdırma
        /*
      Block t = head;
      int ciftSayac =0 ;

      while (t!=null)
      {
          if (t.data%2==0)
          {
              Console.WriteLine(t.data);
              ciftSayac++;
          }

          t = t.next;
      }
      Console.WriteLine("Sayac:"+ciftSayac);
        */
        #endregion





        //head ilk elemanına bakmaktadır 
        //bu listenin aynısını ilk elemanı first olacak şekilde kopyalayınız
        //bu listenin elemanını tersten ekleyiniz
        //bu liste dairesel linked list ise eleman sayısını bulunuz.
        #endregion
    }
}
