using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları2022
{
    class QueueClass
    {
        #region KUYRUK VERİ YAPISI

        /* FİFO  -> First in First out / İlk giren İlk çıkar */
        /* rear  -> Kuyruğun sonun ifade eder ve eleman ekleme işlemi buradan başlar*/
        /* front -> Kuyruğun başını temsil eder ve eleman çıkarma işlemi buradan başlar*/
        /* Enqueue -> Kuyruğa eleman eklenmesi / kuyruğun arkasından başlanır */
        /* Dequeue -> Kuyruktan eleman çıkarılması / kuyruğun önünden başlanır */
        /* Kuyruk doluyken eleman eklenmesi OVERFLOW hatası döndürür */
        /* Kuyruk boşken eleman silinmesi UNDERFLOW hatası döndürür*/
        
        
        #endregion

        #region QUEUEU METOTLARI

        class Block
        {
            public int data;
            public Block next;
            public Block prev;
        }

        static int[] queue = new int[100];
        static int front = 0; // Kuyruğun Başı
        static int rear = -1; // Kuyruğun Sonu

        static int elemanSayisi()
        {
            return rear - front + 1;
        }

        static void move()
        {
            for (int i = 0; i <= elemanSayisi(); i++)
            {
                queue[i] = queue[front + i];
            }
            rear = elemanSayisi() - 1;
            front = 0;
        }

        static void enqueue(int data) //Kuyruğa veri ekleme
        {
            if (elemanSayisi() == queue.Length)
            {
                move();
            }
            rear++;
            queue[rear] = data;
        }
        static int dequeue() //Kuyruktan veri çıkarma
        {
            int data = queue[front];
            front++;
            front = front % queue.Length;
            return data;
        }

        static Block rearNew = null; //Linked List ile veri ekleme ve çıkarma için
        static Block frontNew = null;

        static void enqueueLinked(int queData)
        {
            Block bl = new Block();
            bl.data = queData;
            bl.next = null;
            bl.prev = null;

            if (rearNew == null)
            {
                rearNew = bl;
                frontNew = bl;
            }
            else
            {
                rearNew.next = bl;
                bl.prev = rearNew;
                rearNew = bl;
            }
        }

        static int dequeueLinked()
        {
            int queData = frontNew.data;
            frontNew = frontNew.next;
            if (frontNew == null)
            {
                rearNew = null;
            }
            return queData;
        }


        #endregion

        static void QueueMetot() // BU KODLARI MAİN METODUNDA ÇALIŞTIRIN
        { 
            #region QUEUE
            /*
            Queue<string> q = new Queue<string>();
            q.Enqueue(@"c:\spark");
            while (q.Count > 0)
            {

                string st = q.Dequeue();
                Console.WriteLine(st);
                DirectoryInfo di = new DirectoryInfo(st);
                DirectoryInfo[] dirs = di.GetDirectories();
                foreach (DirectoryInfo item in dirs)
                {
                    q.Enqueue(item.FullName);
                }
            }*/

            #endregion
        }
    }
}
