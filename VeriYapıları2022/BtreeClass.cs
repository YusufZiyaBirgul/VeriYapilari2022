using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları2022
{
    class BtreeClass
    {
        #region TREE VERİ YAPISI

        /* Doğrusal veri yapıları olan diziler, bağlı listeler, yığınlar ve kuyruklardan farklı olarak, 
         * doğrusal olmayan hiyerarşik bir veri yapısıdır*/
        /* Döngü içermeyen veri yapısıdır (İki çocuğun birbirine bağlanması). Recursive olarak yazılır*/
        /* Node (Düğüm)           -> ağacın elemanlarıdır */
        /* Edges (Dal/Kenar)      -> süğümleri birbirine bağlar*/
        /* Root (Kök)             -> ağacın en tepesindeki elemanıdır*/
        /* Parent (baba)          -> Çocuğu olan düğümlerdir*/
        /* Child (Çocuk)          -> Düğüme bağlı olan alt düğümlerdir*/
        /* Leaf (Yaprak)          -> Çocuğu olmayan düğümlerdir*/
        /* Subtree                -> Bir düğümün alt ağaçlarıdır*/
        /* Sibling (kardeş düğüm) -> Aynı babaya sahip düğümlerdir*/
        /* Descendant (varisler)  -> Bir düğüme bağlı tüm alt düğümlere o düğümün varisleri denir*/
        /* Ancestor (ata)         -> Bir düğümden köke kadar izlenen yoldaki diğer tüm düğümler, o düğümün atalardır*/
        /* Path (yol)             -> Bir düğümün aşşağıya doğru bir başka düğüme gidebilmek için üzerinden geçilmesi gerek düğümlerin listesi */
        /* Depth of Tree (Ağacın derinliği) -> Kök düğümden en uçtaki yaprak düğüme kadar olan uzaklıkdır / kök düğümün derinliği 1 dir*/
        /* Derinlik               -> Bir düğümün kök düğüme olan uzaklığıdır*/
        /* Height (yükseklik)     -> O düğümden kendisiyle ilişkili en uzak yaprak düğüme giden yolun uzunluğudur*/
        /* Düzey                  -> İki düğüm arasındaki yolun üzerinde bulunan düğümlerin sayısı /Kök düğümün düzeyi 1 / doğrudan köke bağlı düğümlerin düzeyi 2 */
        /*Degree (derece)         -> Bir düğümün derecesi çocuk sayısına eşittir*/
        /*https://nerdbook.wordpress.com/2018/03/28/agac-veri-yapisi/ Bu yazdıklarımın şekillerine bu linkten ulaşabilirsiniz*/



        #endregion


        #region BTREE METOTLARI

        class Block
        {
            public int data;
            public Block next;
            public Block prev;
        }


        static Block frontTree = null;
        static Block rearTree = null;
        static int[] Btree = new int[100];

        class blockBtree
        {
            public int data;
            public blockBtree left;
            public blockBtree right;
        }

        static void btreeYaz(int parent)
        {
            Console.WriteLine(Btree[parent * 2 + 1]);
            Console.WriteLine(Btree[parent * 2 + 2]);
        }

        static void btreeYazRecursive(int[] btree, int indis)
        {
            if (indis >= btree.Length) return;

            Console.WriteLine(btree[indis]);

            btreeYazRecursive(btree, 2 * indis + 1); //LEFT CHİLD
            btreeYazRecursive(btree, 2 * indis + 2); //RİGHT CHİLD
        }


        static bool bulundu = false;

        static void findElementinBtreeVoid(int[] btree, int indis)
        {
            if (indis >= btree.Length) return;
            if (btree[indis] == 76) bulundu = true;

            findElementinBtreeVoid(btree, 2 * indis + 1);
            findElementinBtreeVoid(btree, 2 * indis + 2);

            //Burada O(2^n) karmaşıklığa sahip
        }

        static int findElementinBtreeInt(int[] btree, int indis)
        {
            if (indis >= btree.Length) return 0;

            if (btree[indis] == 76) return 1 + findElementinBtreeInt(btree, 2 * indis + 1) + findElementinBtreeInt(btree, 2 * indis + 2);

            else return 0 + findElementinBtreeInt(btree, 2 * indis + 1) + findElementinBtreeInt(btree, 2 * indis + 2);
            //Burada O(ln(n)) karmaşıklığa sahip
        }

        static int sayac = 0;
        static void findElementInBtree(blockBtree bt)
        {
            if (bt == null) return;
            if (bt.data == 76) sayac++;

            findElementInBtree(bt.left);
            findElementInBtree(bt.right);
        }

        static void btreeElemanEkle(blockBtree btree, int eklenecekVeri)
        {
            // Ağaca veri ekleme sadece yapraklarda olur. Araya eleman ekleme yapılamaz

            if (btree == null)
            {
                return;
            }

            if (btree.data < eklenecekVeri) //30
            {
                if (btree.right != null)
                {
                    btreeElemanEkle(btree.right, eklenecekVeri);
                }

                else
                {
                    blockBtree bt = new blockBtree();
                    bt.data = eklenecekVeri;
                    bt.left = null;
                    bt.right = null;
                    btree.right = bt;
                }
            }
            else
            {
                if (btree.left != null)
                {
                    btreeElemanEkle(btree.left, eklenecekVeri);
                }

                else
                {
                    blockBtree bt = new blockBtree();
                    bt.data = eklenecekVeri;
                    bt.left = null;
                    bt.right = null;
                    btree.left = bt;
                }
            }
        }

        static int btreeSearch(blockBtree btree, int arananDeger) //30
        {
            if (btree == null) return 0;
            if (btree.data == arananDeger) return 1;

            if (btree.data < arananDeger)
            {
                return btreeSearch(btree.right, arananDeger);
            }

            else
            {
                return btreeSearch(btree.left, arananDeger);
            }
        }

        static blockBtree btreeLinkedListOlustur(int[] btree, int indis) // Btree yi Linked List ile oluşturma
        {
            if (indis >= btree.Length) return null;
            blockBtree bt = new blockBtree();
            bt.data = btree[indis];
            bt.left = btreeLinkedListOlustur(btree, indis * 2 + 1);
            bt.right = btreeLinkedListOlustur(btree, indis * 2 + 2);
            return bt;
        }
        
        static int[] btree = { 50, 17, 72, 12, 23, 54, 76, 9, 14, 19, 0, 0, 67 };

        #endregion

        static void btreeMetot() //BURDAKİ KODLARI MAİN METODUNDA ÇALIŞTIRIN
        {
            #region BTREE

            /* int[] btree = new int[15];
             btree[0] = 50;

             btree[1] = 17;
             btree[2] = 72;
             btree[3] = 12;
             btree[4] = 23;
             btree[5] = 54;
             btree[6] = 76;

             btree[7] = 9;
             btree[8] = 14;
             btree[9] = 19;
             btree[10] = -1; // Null demektense -1 değerini verdik
             btree[11] = -1; // -1 parent'ın child'ı yok demek
             btree[12] = 67;
             btree[13] = -1;
             btree[14] = -1;*/

            #region Recursive Btree Yazdırma 

            //yazRecursiveBtree(btree,0);
            #endregion

            #region Recursive Olmayan Btree Yazdırma 
            /* Stack<int> stack = new Stack<int>();
             stack.Push(0); //Kök(Root) Eleman
             while (stack.Count > 0)
             {
                 int indis = stack.Pop();
                 Console.WriteLine(btree[indis]);
                 indis = indis * 2 + 1;
                 if (indis <= 14)
                 {
                     stack.Push(indis);
                 }
                 indis++;
                 if (indis <= 14)
                 {
                     stack.Push(indis);
                 }
             }*/
            #endregion

            #region BTREE İçerisinde Eleman Bulma 
            /*
            Stack<int> st = new Stack<int>();
            st.Push(0); // Root eleman
            bool bulundu = false;
            while (st.Count>0)
            {
                int indis = st.Pop();
                Console.WriteLine(btree[indis]);
                
                if (btree[indis] == 76) { bulundu = true; break; }
                
                indis = indis * 2 + 1;

                if (indis < btree.Length) st.Push(indis);

                indis++;

                if (indis < btree.Length) st.Push(indis);
            }
            if (bulundu) Console.WriteLine("Bulundu");

            else Console.WriteLine("Bulunamadı");
            */

            #endregion

          

            #endregion
        }
    }
}
