using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack72
{
    class Program
    {
        static void Main(string[] args)
        {//creating object stack class
            StackLinkedList list = new StackLinkedList();
            //calling push method
            list.Push(70);
            list.Push(30);
            list.Push(56);
            //calling display method
            list.Display();
            Console.ReadLine();

        }
    }
}
