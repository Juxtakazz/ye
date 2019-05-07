using System;

namespace jEf
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int bUrh = Convert.ToInt32(Console.ReadLine());
            
            int sum = 0;

            for (int x = 1; x <= bUrh; x++ )
            {
                Console.Write(x + " ");
                sum += x;
            }

            Console.Writeline("The sum is "+ sum); 
            Console.ReadKey();
            
        }
    }
}
