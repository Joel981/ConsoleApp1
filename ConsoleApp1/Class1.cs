using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Class1:Program
    {
        
        public void add(int[] a1)
        {
            int sum = 0;
            foreach (var item in a1)
            {
                sum = sum + item;
            }
            Console.WriteLine("the total sum of an array is : " + sum);
        }
       
        public void s1(int a,int b)
        {
            int s = a + b;
            Console.WriteLine(s);
        }

        public void s1(int a)
        {
            int s = a + 1;
            Console.WriteLine(s);
        }
    }
}
