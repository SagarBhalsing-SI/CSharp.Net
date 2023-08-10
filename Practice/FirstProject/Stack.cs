//Implementing Stack using single Queue.
namespace FirstProject
{
    internal class Stack
    {
        public Queue<int> q = new Queue<int>();

        public void push(int x)
        {
            int s = q.Count;
            q.Enqueue(x);
            for (int i = 0; i < s; i++)
            {
                q.Enqueue(q.Peek());
                q.Dequeue();
            }
        }
        public void pop()
        {
            if (q.Count == 0)
            {
                Console.WriteLine("Empty Stack");
            }
            else
            {
                 q.Dequeue();
            }
        }
        public void Display()
        {
            if (q.Count == 0)
            {
                Console.WriteLine("Empty Stack");
            }
            else
            {
                int x = q.Count;
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine(q.Dequeue());
                }
            }
        }
        public int size()
        {
            return q.Count;
        }
       
        public static void Main()
        {
            Stack stack = new Stack();
            stack.push(10);
            stack.push(20);
            stack.push(30);
            stack.push(40);
            Console.WriteLine("Size of the Stack is "+stack.size());
            stack.Display();

            stack.pop();
            stack.pop();

        }
    }

}

