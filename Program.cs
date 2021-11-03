using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {


            ////creating object stack class
            //StackLinkedList list = new StackLinkedList();
            ////calling push method
            //list.Push(70);
            //list.Push(30);
            //list.Push(56);
            ////calling display method
            //list.Display();
            ////calling IsEmpty method
            //list.IsEmpty();
            //list.Display();

            //Console.ReadLine();

            //creating object stack class
            QueueLinkedList queue = new QueueLinkedList();
            //calling Enquue method
            queue.Enqueve(56);
            queue.Enqueve(30);
            queue.Enqueve(70);
            //calling display method
            queue.Display();
            Console.ReadLine();

        }
    }   
}

