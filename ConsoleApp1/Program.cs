using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classe1 = new Class1(new Class2());
            classe1.Traitement();

            classe1 = new Class1(new Class3());
            classe1.Traitement();
        }
    }
}
