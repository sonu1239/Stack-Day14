using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueLinkedList
{
    public class QueueLinkedList
    {
        internal Node front;
        //creating Enqueue method for adding element in list 
        //Enqueue method is same as add first method in linked list
        internal void Enqueve(int data)
        {
            //creating node object of Node class
            Node node = new Node(data);
            //Checking front is null or not
            if (this.front == null)
            {
                this.front = node;
            }
            //if this.front is not null then else block will execute
            else
            {
                Node temp = front;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            //display  element in Queue
            Console.WriteLine("{0} added into Queue", node.data);
        }
        //this method for display
        internal void Display()
        {
            //declaring temp variable
            Node temp = this.front;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
            }
            //while loop running upto temp value will null
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
