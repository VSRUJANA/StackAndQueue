using System;

namespace DS_StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Program!");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            Console.Write("Stack : ");
            linkedListStack.Display();
            Console.WriteLine("");
            linkedListStack.Peek();
            linkedListStack.Pop();
            Console.Write("Stack : ");
            linkedListStack.Display();
            Console.WriteLine("");
            Console.Write("Emptying Stack : \n");
            linkedListStack.IsEmpty();
            linkedListStack.Display();
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            Console.Write("Queue : ");
            linkedListQueue.Display();
            Console.WriteLine("");
            linkedListQueue.Dequeue();
            Console.Write("Queue : ");
            linkedListQueue.Display();
        }
    }
}
