using System;
using System.Data;

namespace AdoSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============== DataSet generation =================");
            DataSet data = DisconnectedMode.RunSelectCommand(0);
            data.WriteData();

            ConnectedMode.RunUpdateCommand(2, "Thomas");

            Console.WriteLine("=============== DataSet reading after update =======");
            data.WriteData();

            Console.WriteLine("=============== DataSet RE-generation ==============");
            data = DisconnectedMode.RunSelectCommand(0);
            data.WriteData();

            Console.ReadLine();
        }
    }
}
