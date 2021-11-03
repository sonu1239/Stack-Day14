using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack72
{
    class StackLinkedList
    {
        internal Node top;
        //creating push method for adding element in list 
        //push method is same as add first method in linked list
        internal void Push(int data)
        {
            //creating node object of Node class
            Node node = new Node(data);
            //Checking top is null or not
            if (this.top == null)
            {
                node.next = null;
            }
            //if this.top is not null then else block will execute
            else
            {
                node.next = this.top;
            }
            //linking node
            this.top = node;
            //display pushed element in stack
            Console.WriteLine("{0} pushed into stack", node.data);
        }
        //this method for display
        internal void Display()
        {
            //declaring temp variable
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            //while loop running upto temp value will null
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        //
        internal void Peek()
        {
            if (this.top == null)
                Console.WriteLine("The stack is empty");
            Console.WriteLine("\n{0} is in the top of stack", this.top.data);
        }
        //This method for deleting  the first node of stack
        internal void Pop()
        {
            if (this.top == null)
                Console.WriteLine("Deletion not possible");
            //To show deleted element
            Console.WriteLine("Deleted node from stack : " + this.top.data);
            this.top = this.top.next;
        }
        //This method for deleting each element 
        internal void IsEmpty()
        {
            //while loop repeatedly runs until last elenment is not deleted 
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
