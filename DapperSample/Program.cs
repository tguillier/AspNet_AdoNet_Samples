using System;

namespace AdoSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quelques liens dans la classe DapperMode :-)

            DapperMode.RunSelectCommand(0);
            DapperMode.RunUpdateCommand(2, "Thomas");

            Console.ReadLine();
        }
    }
}
