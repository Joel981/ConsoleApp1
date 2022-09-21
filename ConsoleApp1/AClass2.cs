using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    public class AClass2 : Interface1
    {
        public void Ianimal()
        {
            Console.WriteLine("hello");
        }
		public void exep()
        {
			try
			{
				int a = 10;
				int b = 0;
				int c=a+b;
                Console.WriteLine(c);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
        
    }
}
