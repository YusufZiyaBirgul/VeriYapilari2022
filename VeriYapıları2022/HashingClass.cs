using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları2022
{
    class HashingClass
    {


        #region HASHING METOTLARI
        class Block
        {
            public int data;
            public Block next;
            public Block prev;
        }

        static int[] hash = new int[100];

        static Block[] coll = new Block[100]; //Çarpışma--Collision

        static int hasing(int data)
        {
            data = data - 213205001;
            data = data % 100;
            return data;
        }

        static void ekle(int data)
        {
            //BU KISMI DERSTEN BAĞIMSIZ KENDİ ANLADIĞIM ŞEKİLDE YAZDIM
            /*
            //HASİNG İŞLEMİ NASIL GERÇEKLEŞİR
            // ŞİMDİ ELİMİZDE DİZİ BOYUTU 6 OLAN BİR DİZİ VAR
            // EKLEMEK İSTEĞİMİZ SAYI 15 OLSUN
            // 15 % (MOD) 6 =3 OLUR YANİ DİZİNİN 3. İNDİSİNE 15 İ YAZARIZ 
            // EKLEMEK İSTEĞİMİZ SAYI 16 OLSUN
            // 16 % (MOD) 6 =4 OLUR YANİ DİZİNİN 4. İNDİSİNE 16 YI YAZARIZ 
            // EĞER X % 6 = 3 OLURSA 15 İLE X İ LİNKED LİST ŞEKLİNDE BİRBİRİNE BAĞLARIZ
            // AYNI ŞEKİLDE X % 6 = 4 OLURSA X İLE 16 YI LİNKED LİST ŞEKLİNDE BİRBİRİNE BAĞLARIZ
            //BU İŞLEMLER BU ŞEKİLDE DEVAM EDER 

            //ÖRNEK
            //NEW[] DİZİ=NEW INT[5]; DİZİ BOYUTU 5   İNDİSLER => 0-1-2-3-4  
            //DATA = 94
            //94 % 5 = 4 YANİ DİZİ[4] = 94
            //DATA = 24
            //24 % 5 = 4 YANİ DİZİ[4] = 94 --> 94.NEXT = 24
            */



            int indis = hasing(data);
            if (hash[indis] == 0)
            {
                hash[indis] = data;
            }
            else
            {
                //Normal Çözüm
                /*  for (int i = 0; i < hash.Length; i++)
                  {
                      if(hash[i]==0)
                      {
                          hash[i] = data;
                          break;
                      }
                  }*/

                //Linked List Çözümü
                Block bl = new Block();
                bl.data = data;
                if (coll[indis] != null) coll[indis].prev = bl;

                bl.next = coll[indis];
                coll[indis] = bl;
            }
        }

        static int search(int data)
        {
            int indis = hasing(data);
            int bulundu = 0;

            if (hash[indis] == data) return 1;

            else
            {
                //Normal Çözüm
                /* for (int i = 0; i < hash.Length; i++)
                 {
                     if (hash[i] == data)
                     {
                         bulundu = 1;
                         break;
                     }
                 }*/


                //Linked List Çözümü
                Block temp = coll[indis];

                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        bulundu = 1;
                        break;
                    }
                    temp = temp.next;
                }
            }
            return bulundu;
        }

        static void delete(int data)
        {
            int indis = hasing(data);

            if (hash[indis] == data)
            {
                hash[indis] = 0;

                if (coll[indis] != null)
                {
                    hash[indis] = coll[indis].data;
                    coll[indis] = coll[indis].next;
                }
                else
                {
                    hash[indis] = 0;
                }

            }




        }

        #endregion


        static void hashingMetot() // BU KODLARI MAİN METODUNDA ÇALIŞTIRIN
        {

            #region HASHİNG

            //hashing arama/search en hızlı arama x[indis] üzerinden
            //diziler üzerinde implement //hashing linked list ile yazılamaz//
            //hangi veri arama için kullanılacak
            //veri---->sayi ya
            //çevirmeliyiz
            //dönüşüm hash function
            //dengeli dağıtmak
            //hashing hash function performansına bağlıdır. 
            //moduler % kullanacağız
            //ABC = 65+66+67 assci değerleri    
            //A = 65    
            //1,2,3,4,5,6,7
            //2132055001...213205999 - 213205001;    213205057  213205024
            //213205025=2+1+3+2+0+5+0+2+5=20






            #region EKLE

            /* ekle(213205005);
             ekle(213205105);
             ekle(213205205);*/
            //collusion oluştu mod 100 olduğu için aynı yere yazdılar overrite oluştu
            #endregion

            #region SEARCH

            if (search(213205005) == 1)
            {
                Console.WriteLine("Bulundu");
            }
            else
            {
                Console.WriteLine("Bulunamadı");
            }
            if (search(213205205) == 1)
            {
                Console.WriteLine("Bulundu");
            }
            else
            {
                Console.WriteLine("Bulunamadı");
            }

            #endregion

            #endregion
        }
    }
}
