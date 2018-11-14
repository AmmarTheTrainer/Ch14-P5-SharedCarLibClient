using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ch14_P2_CarLibrary;

namespace Ch14_P5_SharedCarLibClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Shared Assembly Client *****");
            SportsCar c = new SportsCar();

            c.TurboBoost();
            Console.ReadLine();
        }
    }
}
