using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_32_prakt_16_4_OAP_Давыдова
{
    class Program
    {
        static void Main(string[] args)
        {
            Procces pro = new Procces();
            Procces pro1 = new Procces();

            pro.Length = 5;
            pro.Start = 1;
            pro.End = 20;

            pro1.Length = 5;
            pro1.Start = -10;
            pro1.End = 10;

            int[] integer = new int[pro.Length];
            int[] integer1 = new int[pro1.Length];

            pro.rand(integer, pro.Length, pro.Start, pro.End);
            pro1.rand(integer1, pro1.Length, pro1.Start, pro1.End);

            try
            {
                Console.Write("индекс элемента = ");
                int vv = Int16.Parse(Console.ReadLine());
                Console.WriteLine("One[{0}]={1}", vv, integer[vv]);
            }
            catch { Console.WriteLine("индекс элемента выходит за рамки массива"); }

            pro.Sum(integer, integer1);
            Console.ReadLine();

            pro.Minus(integer, integer1);

            pro.mult(integer, 3);
            Console.ReadLine();

        }
    }
    class Procces
    {
        public int Length;
        public int Start;
        public int End;

        public void rand(int[] Arr, int Length, int Start, int End)
        {
            Random random = new Random();
            for (int i = 0; i < Length; i++)
            {
                Arr[i] = random.Next(Start, End);
                Console.Write("{0} ", Arr[i]);
            }
            Console.ReadLine();
        }
        public void Sum(int[] a, int[] b)
        {
            for (int i = 0; i < Length; i++)
            {
                a[i] += b[i];
                Console.Write("{0} ", a[i]);
            }
        }
        public void Minus(int[] a, int[] b)
        {
            for (int i = 0; i < Length; i++)
            {
                a[i] -= b[i];
                Console.Write("{0} ", a[i]);
            }
        }
        public void mult(int[] a, int temp)
        {
            for (int i = 0; i < Length; i++)
            {
                a[i] *= temp;
                Console.Write("{0} ", a[i]);
            }
        }
    }
}

