using System.Collections.Generic;

namespace AdoSample
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Command> Commands { get; set; }
    }

    public class Command
    {
        public Client Client { get; set; }
    }
}