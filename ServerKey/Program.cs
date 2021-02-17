using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerKey
{
    class Program
    {
        static void Main(string[] args)
        {
            bool blRunning = true;
            Server server = new Server();
            while (blRunning)
                server.StartListening();
        }
    }
}
