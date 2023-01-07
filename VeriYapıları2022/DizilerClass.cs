using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları2022
{
    class DizilerClass
    {
        #region BAĞLI LİSTELER VS DİZİLER

        /* 1) Bağlı listler her bir elemanın işaretçiler kullanılarak bir sonrakine bağlandığı aynı türdeki öğelerin sıralı bir koleksiyonudur*/
        /* 1) Diziler, aynı tipteki veri türü elemaanlarının bir koleksiyonudur */

        /* 2) Bağlı listelerin elemanlarına sıralı olarak erişebilir*/
        /* 2) Dizilerin elemanların rastgele erişilebilir*/

        /* 3) Bağlı liste elemanları bellekte rastgele saklanır*/
        /* 3) Dizilerin elemanları bellekte rastgele saklanır*/

        /* 4) Bağlı listelerde elemanların silinmesi ve eklenmesi hızlı ve kolaydır*/
        /* 4) Dizilerin elemanlarının silinmesi ve eklenmesi maaliyetlidir*/

        /* 5) Bağlı liste elemanları için bellek çalışma zamanı sırasında atanır (DİNAMİK BELLEK AYIRMA) */
        /* 5) Dizi elemanları için bellek derleme esnasında atanır (STATİK BELLEK AYIRMA)*/

        /* 6) Bağlı listelerin boyutu yeni elemanlar eklendiğinde/silindiğinde büyür küçülür*/
        /* 6) Dizilerin boyutu yeni elemanlar eklendiğinde/silindiğinde büyümez küçülmez*/

        /* 7) Bağlı listelerde doğrusal arama yapılabilir O(n)*/
        /* 7) Dizilerde doğrusal ve ikili arama saypılabilir O(1)*/
 
        /* 8) Bağlı listeler daha fazla bellek kullanır*/
        /* 8) Diziler daha az bellek kullanır*/

        #endregion

        #region ÇOK BOYUTLU DİZİ METOTLARI
        static int toplaRec(int[,] dizi, int x, int n1, int y, int n2) //n1 satır n2 sütun 
        {   //2 boyutlu dizinin recursive toplamı

            if (n1 == 1 && n2 == 1) return dizi[x, y];

            if (n1 == 1) return toplaRec(dizi, x, n1, y, (n2 / 2)) + toplaRec(dizi, x, n1, y + (n2 / 2), n2 - (n2 / 2));

            else return toplaRec(dizi, x, (n1 / 2), y, n2) + toplaRec(dizi, x + (n1 / 2), n1 - (n1 / 2), y, n2);

        }
        #endregion


        static void diziMetot() // BU KODLARI MAİN METODUNDA ÇALIŞTIRIN
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
             Input : dizi[3][3] = {1 2 3
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

            #region Dizi içerisinde en çok tekrar eden sayı
            /*
                        int[,] dizi = { { 0,1,1 },
                                        { 1,1,0 } };
                                         

                        int a = 0;
                        int b = 0;
                        int enB = 0;

                        while (a < 2)
                        {
                            int tekrar = 0;

                            for (int i = 0; i < 2; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    if (dizi[a, b] == dizi[i, j] )
                                    {
                                        tekrar++;
                                    }
                                }

                                if (enB < tekrar)
                                {
                                    enB = tekrar;
                                }
                            }

                            b++;
                            if (b == 2)
                            {
                                a++;
                                b = 0;
                            }

                        }
            

            Console.WriteLine(enB);*/
            #endregion

            #endregion
        }
    }
}
