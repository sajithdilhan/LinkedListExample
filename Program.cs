using System;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new();

            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(6);
            linkedList.Add(300);

            var x = linkedList.PrintAllNodes();

            foreach (var item in x)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
