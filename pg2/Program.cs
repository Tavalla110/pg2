using System;

namespace pg2
{
    class Project1
    {
        public static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            int num3 = Convert.ToInt32(c);
            if (num1 + num2 > num3 && num1 + num3 > num2 && num2 + num3 > num1)
            {
                mohit(num1, num2, num3);
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static void mohit(int x, int y, int z)
        {
            int w = x + y + z;
            Console.WriteLine(w);
        }
    }
}
