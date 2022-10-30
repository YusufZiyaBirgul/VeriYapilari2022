using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları2022
{
    class Program
    {

        #region ÇOK BOYUTLU DİZİ METOTLARI
        static int toplaRec(int[,] dizi, int x, int n1, int y, int n2) //n1 satır n2 sütun 
        {   //2 boyutlu dizinin recursive toplamı

            if (n1 == 1 && n2 == 1) return dizi[x, y];

            if (n1 == 1) return toplaRec(dizi, x, n1, y, (n2 / 2)) + toplaRec(dizi, x, n1, y + (n2 / 2), n2 - (n2 / 2));

            else return toplaRec(dizi, x, (n1 / 2), y, n2) + toplaRec(dizi, x + (n1 / 2), n1 - (n1 / 2), y, n2);

        }
        #endregion




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




        static void Main(string[] args)
        {
            #region ÇOK BOYUTLU DİZİLER 

            #region  dizinin en büyük elemanının tek döngü ile bulun
            /*
             int[,,,,] x = new int[3, 4, 5, 6, 7];

             x[0, 0, 0, 0, 0] = 7;
             x[0, 0, 0, 0, 1] = 8;
             x[0, 0, 0, 1, 0] = 9;
             x[0, 0, 0, 1, 1] = 15;
             x[0, 0, 1, 0, 0] = 10;
             x[0, 1, 0, 0, 0] = 11;
             x[1, 0, 0, 0, 0] = 12;


             x[1, 2, 3, 4, 5] = 180;
             x[2, 2, 4, 3, 5] = 140;

             int a = 0;
             int b = 0;
             int c = 0;
             int d = 0;
             int e = 0;

             int enB = 0;

             while (a != 2 || b != 3 || c != 4 || d != 5 || e != 6)
             {
                 if (enB < x[a, b, c, d, e])
                 {
                     enB = x[a, b, c, d, e];
                 }
                 e++;
                 if (e==7)
                 {
                     e = 0;
                     d++;
                 }
                 if (d == 6)
                 {
                     d = 0;
                     e = 0;
                     c++;
                 }
                 if (c==5)
                 {
                     c = 0;
                     d = 0;
                     e = 0;
                     b++;
                 }
                 if (b==4)
                 {
                     b = 0;
                     c = 0;
                     d = 0;
                     e = 0;
                     a++;
                 }
                 if (a==3)
                 {
                     a = 0;
                     b = 0;
                     c = 0;
                     d = 0;
                     e = 0;
                 }
             }

             Console.WriteLine(enB);
            */
            #endregion

            #region deneme en büyük eleman tek dizi
            /*
            int[,,] x = new int[2, 2, 3];
           
            x[0, 0, 0] = 15;
            x[0, 0, 1] = 10;
            x[0, 1, 0] = 19;
            x[1, 0, 0] = 90;

            int a = 0;
            int b = 0;
            int c = 0;
           

            int enB = 0;

            while (a != 1 || b != 1 || c != 2 )
            {
                if (enB < x[a, b, c])
                {
                    enB = x[a, b, c];
                }
                c++;
                if (c == 3)
                {
                    c = 0;
                    b++;
                }
                if (b == 2)
                {
                    b = 0;
                    c = 0;
                    
                    a++;
                }
                if (a == 2)
                {
                    a = 0;
                    b = 0;
                    c = 0;
               
                }
            }
            Console.WriteLine(enB);
            */
            #endregion

            #region Dizi içerisinde en çok tekrar eden sayı
            /*
            int[] dizi = { 1, 2, 3, 1, 3, 3, 3, 3, 3, 3, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5 };

            int enCok = 0;


            for (int i = 0; i < dizi.Length; i++)
            {
                int sayac = 0;

                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[i] == dizi[j])
                    {
                        sayac += 1;
                    }
                }
                if (enCok < sayac)
                {
                    enCok = sayac;
                }
            }

            Console.WriteLine(enCok);
            */

            #endregion

            #region Bir matrisi 180 derece döndürme
            /*
            int[,] dizi = {  { 1, 2, 3 },       //7 4 1  //9 8 7
                             { 4, 5, 6 },       //8 5 2  //6 5 4
                             { 7, 8, 9 } };     //9 6 3  //3 2 1

            //Output
            //9 8 7 
            //6 5 4
            //3 2 1

            int indis = 0;

            for (int i = 2; i >=0; i--)
            {
                for (int j = 2; j >=0; j--)
                {
                    Console.Write(dizi[i,j]+" ");
                }
                Console.WriteLine();
            }


            */
            #endregion

            #region En fazla 1 in olduğu satırı bul
            /*
            int[,] dizi = { { 0, 0, 0, 1 },
                            { 0, 1, 1, 1 },
                            { 1, 1, 1, 1 },
                            { 0, 0, 0, 0 } };

            int enB = 0;
            for (int i = 0; i < 4; i++)
            {
                int toplam = 0;
                for (int j = 0; j < 4; j++)
                {
                    toplam += dizi[i, j];
                    if (toplam > enB)
                    {
                        enB = toplam;
                    }
                    
                }
                Console.WriteLine(toplam);
            }
            Console.WriteLine("En Fazla:"+enB);

            */
            #endregion

            #region Sıralı 2 boyutlu bir dizinin medyanını bul

            /*
            int[,] dizi = {{1,3,5},
              {2,6,9},
              {3,6,9} };

            int max = 2;
            int min = 2;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (max < dizi[i, j]) max = dizi[i, j];

                    if (min > dizi[i, j]) min = dizi[i, j];

                }
            }

            int medyan = (max + min) / 2;

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(medyan);




            */
            #endregion

            #region iki matrisi çarpma
            /*
            int[,] mat1 = { { 1, 2 },
                            { 2, 0 },
                            { 3, 1 } }; //pXr 3X2

            int[,] mat2 = { { 4, 3 },
                            { 1, 2 } }; //nXm 2X2


            //  C11 = 1x5+2x7 =19 mat1[0,0] * mat2[0,0] + mat1[0,1] * mat2[1,0];
            //  C12 = 1x6+2x8 =22 mat1[0,0] * mat2[0,1] + mat1[0,1] * mat2[1,1];
            //  C21 = 3x5+4x7 =43 mat1[1,0] * mat2[0,0] + mat1[1,1] * mat2[1,0];
            //  C22 = 3x6+4x8 =50 mat1[1,0] * mat2[0,1] + mat1[1,1] * mat2[1,1];

            //  {{19, 22},
            //   {43, 50}};

            int r = 2;
            int n = 2;
            int[,] mat3 = new int[3, 3];

            if (r == n)
            {

                int toplam = 0;

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            mat3[i, j] += mat1[i, k] * mat2[k, j];
                        }
                    }

                }

            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(mat3[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region iki matris çarpma recursive //DEVAM ET
            /*
            int[,] mat1 = {{1, 2, 3},
                    {4, 5, 6},
                    {7, 8, 9}};

            int[,] mat2 = {{1, 2, 3},
                        {4, 5, 6},
                    {7, 8, 9}};

            matrisCarpRecursive(mat1, mat2);
            */
            #endregion

            #region herhangi bir sayıyla matris elemanlarını çarpma
            /*
            int[,] mat = { { 1, 2, 3 },
                           { 3, 4, 5 } };

            int carp = 5;

            int[,] yeniMat = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    yeniMat[i, j] += mat[i, j] * carp;
                }
            }


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(yeniMat[i, j]+" ");
                }
                Console.WriteLine();
            }
            */
            #endregion

            #region Üst ve alt üçgen hesaplama
            /*
             Input : matrix[3][3] = {1 2 3
                                     4 5 6
                                     7 8 9}

            Output :
            
            Lower : 1 0 0        Upper : 1 2 3
                    4 5 0                0 5 6
                    7 8 9                0 0 9
            
             */

            /*
            int[,] mat = { { 1, 2, 3 },
                           { 4, 5, 6 },
                           { 7, 8, 9 } };



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i < j) Console.Write("0" +" ");

                    else Console.Write(mat[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i > j) Console.Write("0" + " ");

                    else Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
           */




            #endregion

            #region Bir matrisin tüm satırlarında ortak olan farklı öğeleri bulma //DEVAM ET
            /*
            int[,] mat = {  {2, 1, 4, 3},
                            {1, 2, 3, 2},
                            {3, 6, 2, 3},
                            {5, 2, 5, 3}  };

            int ortak = 0;


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (mat[0, j] == mat[1, j]) ortak++;

                }
            }
            Console.WriteLine(ortak);
            */
            #endregion

            #region her satırdaki en büyük eleman
            /*

            int[,] dizi = { { 1, 2, 3, 4 }, 
                            { 5, 6, 87, 8 },
                            { 9, 10, 11, 12 },
                            { 113, 14, 15, 16 } };

            int enB1 = 0;
            int enB2 = 0;
            int enB3 = 0;
            int enB4 = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (enB1 < dizi[0, j]) enB1 = dizi[0, j];

                    if (enB2 < dizi[1, j]) enB2 = dizi[1, j];
                    
                    if (enB3 < dizi[2, j]) enB3 = dizi[2, j];
                    
                    if (enB4 < dizi[3, j]) enB4 = dizi[3, j];


                }
            }
            Console.WriteLine(enB1);
            Console.WriteLine(enB2);
            Console.WriteLine(enB3);
            Console.WriteLine(enB4);
           */
            #endregion

            #region Matris öğelerini satır bazında k ile kaydırma

            /*
             
             Input : mat[N][N] = {{1, 2, 3},
                     {4, 5, 6},
                     {7, 8, 9}}
            k = 2
            
            Output :
            
            mat[N][N] = {{3, 1, 2}
                         {6, 4, 5}
                         {9, 7, 8}}
            
             */
            /*
            int[,] mat ={ {1, 2, 3, 4},
                          {5, 6, 7, 8},
                          {9, 10, 11, 12},
                          {13, 14, 15, 16} };
            int k = 2;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mat[i, j] = mat[i, j - k];
                }
            }
            */

            #endregion

            #region Köşegen Matris Mi
            /*
            int[,] x = { {1, 0, 0 },
                         {0, 2, 0 },
                         {0, 0, 9 } };

            bool isTrue = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j && x[i, j] != 0)
                    {
                        isTrue = true;
                    }
                    else
                    {
                        isTrue = false;
                    }
                }
            }
            if (isTrue)
            {
                Console.WriteLine("Köşegen Matris");
            }
            else
            {
                Console.WriteLine("Köşegen Değil");
            }*/
            #endregion

            #region dizideki tüm elemanların toplamını recursive bul

            /* int[,] dizi = { { 1, 2, 3, 4 },
                             { 5, 6, 7, 8 },
                             { 9, 10, 11, 12 } };


             Console.WriteLine(toplaRec(dizi, 0, 3, 0, 4));
            */
            #endregion

            #region Dizinin en büyük 2. elemanını bulma
            /*
            int[,,] x = new int[2, 2, 3];

            x[0, 0, 0] = 1;
            x[0, 0, 1] = 2;
            x[0, 0, 2] = 3;

            x[0, 1, 0] = 4;
            x[0, 1, 1] = 5;
            x[0, 1, 2] = 6;

            x[1, 0, 0] = 7;
            x[1, 0, 1] = 8;
            x[1, 0, 2] = 9;

            x[1, 1, 0] = 10;
            x[1, 1, 1] = 11;
            x[1, 1, 2] = 12;

            int a = 0;
            int b = 0;
            int c = 0;

            int k = 0;
            int[] dizi = new int[x.Length];

            int enB = 0;
            int enB2 = 0;
            int enB3 = 0;
            int enB4 = 0;
            int enB5 = 0;

            while (a != 1 || b != 1 || c != 2)
            {
                dizi[k] = x[a, b, c];

                c++;
                if (c == 3)
                {
                    c = 0;
                    b++;
                }
                if (b == 2)
                {
                    b = 0;
                    c = 0;

                    a++;
                }
                if (a == 2)
                {
                    a = 0;
                    b = 0;
                    c = 0;
                }
                k++;
            }
            dizi[11] = x[1, 1, 2];

            for (int i = 0; i < x.Length; i++)
            {
                if (enB < dizi[i])
                {
                    enB2 = enB;
                    enB = dizi[i];
                }
                else if (dizi[i] > enB && dizi[i] != enB)
                {
                    enB3 = enB2;
                    enB2 = dizi[i];
                }
                else if (dizi[i] > enB2 && dizi[i] != enB2 && dizi[i] != enB)
                {
                    //enB4 = enB3;
                    enB3 = dizi[i];
                }

            }
            Console.WriteLine(enB3);*/
            #endregion

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

            }


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
            //Tekli Linked List İle Aynı

            Block t = head;
            while (t != null) //Veya burası t.next!=null yapılabilir
            {
                Console.WriteLine(t.data);
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

            while (t != null)
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
                {                                   // ne yaptıüım anlaşılmadıysa  && t.prev.data ==4 kısmın silip tekrar çalıştırsın
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
                        if (dizi[j]>dizi[k])
                        {
                            enK = dizi[k];
                            dizi[k] = dizi[j];
                            dizi[j] = enK;
                        }
                    }
                }

                sirali.data = enK;

                if (head==null)
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
            }
            */
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
                copy.prev = last;
                if (head == null)
                {
                    head = copy;
                    last = copy;
                }
                else
                {
                    last.next = copy;
                    
                }
                Console.WriteLine(copy.data);

                t = t.next;

            }

            */

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


            #region STACK


            #endregion


            Console.ReadLine();


        }
    }
}
