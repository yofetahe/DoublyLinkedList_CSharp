using System;

namespace DoublyLinkedLists
{

    public class DLinkedLists
    {
        public DllNode Head;

        public DLinkedLists()
        {
            Head = null;
        }

        public void Add(int value)
        {
            DllNode newNode = new DllNode(value);
            if(Head == null)
            {
                Head = newNode;
            } 
            else 
            {
                DllNode runner = Head;
                while(runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = newNode;
                newNode.Prev = runner;
            }
        }

        public bool Remove(int value)
        {
            bool check = false;

            DllNode runner = Head;
            while(runner.Next != null)
            {
                if(runner.Value == value)
                {
                    check = true;
                    DllNode temp = runner;
                    runner.Prev.Next = runner.Next;
                    runner.Next.Prev = temp.Prev;
                    break;
                }
                runner = runner.Next;
            }

            return check;
        }

        public void PrintValues()
        {
            DllNode runner = Head;
            while(runner != null)
            {
                System.Console.WriteLine(runner.Value);
                runner = runner.Next;
            }
        }

        public void Reverse()
        {

            DllNode temp = null;  
            DllNode current = Head;  
    
            /* swap next and prev for all nodes of  
            doubly linked list */
            while (current != null)  
            {  
                temp = current.Prev;  
                current.Prev = current.Next;  
                current.Next = temp;  
                current = current.Prev;  
            }  
    
            /* Before changing head, check for 
            the cases like empty list and 
            list with only one node */
            if (temp != null) 
            {  
                Head = temp.Prev;  
            }  
        }
    }
}