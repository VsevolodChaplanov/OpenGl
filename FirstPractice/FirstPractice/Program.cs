using System;

namespace FirstPractice
{
    class Program
    {
        static public int Sum(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            string a;
            string b;

            a = Console.ReadLine(); // ReadLine as string variable;
            b = Console.ReadLine();

            int aa = int.Parse(a);
            int bb = int.Parse(b);

            Console.WriteLine("Summ of a and b = {0}", Sum(aa, bb));
        }
    }
}
