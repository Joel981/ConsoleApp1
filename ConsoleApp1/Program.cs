using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    public class Program
    {
        public delegate void alpha(int a, int b,int c);
        public void s1(int a, int b)
        {
            int sum = a - b;
            Console.WriteLine(sum);
        }
        public void s2(int a, int b,int c)
        {
            int sum = a - b + c;
            Console.WriteLine(sum);
        }
        
        public static void Main(string[] ars)
        {
            int[] a1 = new int[4];
            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write("element - {0} : ", i);
                a1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Class1 ob = new Class1();
            ob.add(a1);
            ob.s1(10, 20);
            
            ob.s1(4);
            alpha ob2 = new alpha(ob.s2);
            ob2(1, 3, 5);
            AClass2 obj = new AClass2();
            obj.Ianimal();
            
        }
    }
}
