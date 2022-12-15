using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları2022
{
    public class StackClass
    {

        #region STACK METOTLARI

        class Block
        {
            public int data;
            public Block next;
            public Block prev;
        }

        //DİZİ İLE STACK OLUŞTURMA

        static int[] stack = new int[100];
        static int sp = -1; //STACK POİNT herzaman -1 den başlar
        static void push(int data) // STACK'a eleman ekle
        {
            sp++;
            stack[sp] = data;
            //stack[++sp]=data; şeklinde de yazılabilir
        }

        static int pop() //STACK'tan eleman çıkarma
        {
            int data = stack[sp];
            sp--;
            return data;
        }

        static int peek() // Stacktaki o anki bulunan elemana bakar
        {
            return spLinked.data;
        }

        static Block spLinked = null;
        static void linkedPush(int data)
        {
            Block bl = new Block();
            bl.data = data;
            bl.next = null;
            bl.prev = null;
            if (spLinked == null)
            {
                spLinked = bl;
                return;
            }
            bl.next = spLinked;
            spLinked.prev = bl;
            spLinked = bl;
        }


        static int linkedPop()
        {
            int data = spLinked.data;
            spLinked = spLinked.next;
            return data;
        }
        static int carp(int a, int b)
        {
            return a * b;
        }
        static int bolme(int a, int b)
        {
            return a / b;
        }
        static int fark(int a, int b)
        {
            return a - b;
        }
        static int topla(int a, int b)
        {
            return a + b;
        }
        #endregion

        public static void StackMetot() // BU KODLARI MAİN METODUNDA ÇALIŞTIRIN
        {


            #region STACK 

            //FİLO--> First in Last out --> İlk giren Son çıkar
            //LİFO--> Last in First out --> Son giren İlk çıkar
            //işletim sistemleri, oyun yazılımları, bazı yazılımlarda, compiler, infix ve postfix yapılarında, metot çağırmalarında stack kullanır

            #region Push Pop
            /*
            push(1);
            push(2);
            push(3);
            push(4);
            Console.WriteLine(pop());
            Console.WriteLine(pop());
            Console.WriteLine(pop());
            Console.WriteLine(pop());


            linkedPush(10);
            linkedPush(20);
            linkedPush(30);
            Console.WriteLine(linkedPop());
            Console.WriteLine(linkedPop());
            Console.WriteLine(linkedPop());

            for (int i = 0; i < 100; i++)
            {
                push(i);
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(pop());
            }
            Console.ReadLine();*/
            #endregion

            #region Stack Palindromik Sayı
            /*
            string metin = "ey edip adanada pide ye";
            for (int i = 0; i < metin.Length; i++)
            {
                push(metin[i]);
            }


            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == pop()) Console.WriteLine("Palindrom");
                else Console.WriteLine("Palindrom değil");

            }
            */
            #endregion

            #region STACK Substring Bulma 
            /*
            Stack<string> st = new Stack<string>();
            st.Push(@"C:\"); //Bilgisayarınızdaki c dizinini stack'a ekler

            while (st.Count > 0)
            {
                string path = st.Pop();
                string[] dizinler = Directory.GetDirectories(path); //Direcctory'yi kullanabilmek için en üstte !! using System.IO !! eklenmeli
                string[] dosyalar = Directory.GetFiles(path);

                for (int i = 0; i < dizinler.Length; i++)
                {
                    st.Push(dizinler[i]);
                }
                foreach (string item in dosyalar)
                {
                    Console.WriteLine(item);
                }
            }
            */

            #endregion

            #region Stack Parantez Problemi //Açılan parantez kapatılmışmı
            /*
            string s = "([])";

            string left = "{[("; //burada sağ ve sol parantezlerin sıraları aynı olmalı
            string right = "}])";
            int hata = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // IndexOf --> s'in içindeki karakter left'in içerisindeki herhangi bir karakterle eşleşirse bulunan stringin (leftin içindeki)indisini döner 
                int indis = left.IndexOf(s[i].ToString());
                if (indis != -1)
                {
                    push(right[indis]);
                }
                else
                {
                    indis = right.IndexOf(s[i].ToString());
                    if (indis != -1)
                    {
                        if (pop() != right[indis])
                        {
                            hata = 1;
                            break;
                        }
                    }
                }
            }
            if (hata == 1)
            {
                Console.WriteLine("Hatalı");
            }
            else
            {
                Console.WriteLine("Hatasız");
            }*/
            #endregion

            #region Infix to Postfix

            //string infix = "a+b*c-d";
            //string postfix = "";
            //string op = "$(+-*/";

            /*string oncelik = "0011220";
            push((byte)'$');

            for (int i = 0; i < infix.Length; i++)
            {
                if (op.IndexOf(infix[i])==-1)
                {
                    postfix = postfix + infix[i];
                    continue;
                }
                if (infix[i]=='(')
                {
                    push((byte)'(');
                    continue;
                }
                if (infix[i] == ')')
                {
                    while (peek()!='(')
                    {
                        postfix += (char)pop();
                    }
                  pop();
                    continue;
                }

                int a = (byte)peek();
                a = op.IndexOf((char)a);

                if (oncelik[a]>oncelik[op.IndexOf(infix[i])])
                {
                    postfix += (char)pop();
                    push(infix[i]);
                }
                else
                {
                    push(infix[i]);
                }

            }
            while (peek() != '$')
            {
                postfix += (char)pop();
            }

            Console.WriteLine(postfix);

            */
            #endregion

            #region Postfix to Infix

            // string postfix = "ab*c+d-"; //--> a*b+c-d
            //string op = "+-*/";
            /* string operand = "abcd";
             int[] deger = { 1,2,3,3 }; //a=1 b=2 c=3 d=2

             Stack<int> st = new Stack<int>();

             for (int i = 0; i < postfix.Length; i++)
             {
                 if (operand.IndexOf(postfix[i])!=-1)
                 {
                     int indis = operand.IndexOf(postfix[i]);
                     st.Push(deger[indis]);
                     continue;
                 }

                 int karakter2 = st.Pop();
                 int karakter1 = st.Pop();
                 int sonuc = 0;

                 if (postfix[i] == '*') sonuc = bolme(karakter1, karakter2);
                 if (postfix[i] == '/') sonuc = carp(karakter2, karakter1);
                 if (postfix[i] == '+') sonuc = topla(karakter2, karakter1);
                 if (postfix[i] == '-') sonuc = fark(karakter2, karakter1);
                 st.Push(sonuc);
             }


             Console.WriteLine(st.Pop());*/
            #endregion

            #endregion
        }


    }
}
