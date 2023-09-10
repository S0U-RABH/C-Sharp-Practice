using System.Collections;

namespace Stack_And_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack 
            // Stack Declairation
            Stack<int> stack = new Stack<int>();

            //intertion in stack using push()
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            // peek in the stack
            stack.Peek();
            Console.WriteLine("Data in Stack : {0}",stack.Peek());

            // remove data from stack using pop()
            int mystackvalue = stack.Pop();
            Console.WriteLine("Data was romove from Stack : {0}", mystackvalue);
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------QUEUE------------------------------");


            // Queues
            Queue<int> queue = new Queue<int>();

            // intertion in queue using enqueue()
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            foreach (int  item in queue)
            {
                Console.WriteLine(item);
            }
             
            // remove data from Queue using Dequeue()
            int mystackvalues = queue.Dequeue();
            Console.WriteLine("Data was romove from Queue: {0}", mystackvalues);

            // peek in the Queue
            queue.Peek();
            Console.WriteLine("Data in Queue : {0}", queue.Peek());
            Console.ReadKey();
        }
    }
}