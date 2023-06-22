using System;

namespace Queue
{
    public class Queue
    {
        private Node front;  
        private Node rear; 

        
        private class Node
        {
            public int Data;
            public Node Next;
        }
        public void Enqueue(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (front == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }
        public int Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
                return -1; // or throw an exception
            }

            int data = front.Data;
            front = front.Next;

            if (front == null)
                rear = null;

            return data;
        }

        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Node current = front;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Queue Implementation ...");

            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            queue.Display(); // Output: 56 30 70

            int dequeuedElement = queue.Dequeue();
            Console.WriteLine("Dequeued: " + dequeuedElement); // Output: Dequeued: 56

            queue.Display(); // Output: 30 70
        }
    }
}
