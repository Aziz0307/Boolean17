using System;

namespace Boolean17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vvedite nechetnoe trechznachnoe chislo: ");
            int a = int.Parse(Console.ReadLine());
            bool result =(a>=100 && a<1000 && a % 2 !=0) ? true: false;
            Console.WriteLine(result);
        }
    }
}