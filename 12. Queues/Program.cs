using System;
using System.Collections.Generic;
namespace _12._Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining a queue of integers //----importante-----> as filas são importantes de se usarem quando a ordem dos dados importa
            Queue<int> queue = new Queue<int>();

            //adiciona um item ao final da fila
            queue.Enqueue(1);
            //printa um elemento na parte da frente da fila (primeiros elementos)
            Console.WriteLine("The value at the front of the queue is: {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("Top value in the queue is: {0}", queue.Peek());
            queue.Enqueue(3);
            Console.WriteLine("Top value in the queue is: {0}", queue.Peek());

            while (queue.Count > 0)
            {
                //Dequeue() will return the element that was removed from the queue
                Console.WriteLine("The front value {0} was removed from the queue", queue.Dequeue());
                //print the queue count
                Console.WriteLine("Current queue count is: {0}", queue.Count);
            }
        }
    }
}
