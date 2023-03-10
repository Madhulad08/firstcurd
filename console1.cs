using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp2

{

    interface ConsoleApp2
    {
        void show();
    }
    class PartTimeEmployees : ConsoleApp2
    {
        public void show()
        {
            Console.WriteLine("This is a method of interface !!");
        }
  /  }

    class inter
    {
        static void Main(string[] args)
        {
            PartTimeEmployees pte = new PartTimeEmployees();
            pte.show();
            Console.ReadLine();
        }
    }
}