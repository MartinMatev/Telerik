namespace MegaCollections.Tests
{
    using System;

    class Program
    {
        static void Main()
        {
            Deque<int> deque = new Deque<int>();

            deque.AddFront(5);  // 5
            deque.AddFront(10); // 10 5
            deque.AddBack(25);  // 10 5 25
            deque.AddBack(20);  // 10 5 25 20
            int count = deque.Count;    // 4

            Console.WriteLine("Deque count: {0}", count);

            int frontRemoved = deque.RemoveFront();
            int backRemoved = deque.RemoveBack();

            Console.WriteLine("Front element Removed: {0}", frontRemoved);  // 10
            Console.WriteLine("Back element Removed: {0}", backRemoved);    // 20

            int frontPeek = deque.PeekFront();
            int backPeek = deque.PeekBack();

            Console.WriteLine("Peek at first element: {0}", frontPeek); // 5
            Console.WriteLine("Peek at last element: {0}", backPeek);   // 25

            int maxCapacity = deque.Capacity;

            Console.WriteLine("Max deque capacity: {0}", maxCapacity);

            // Add to front
            for (int i = 0; i < 20; i++)
            {
                deque.AddFront(i);
            }

            // Add to back
            for (int i = 0; i < 20; i++)
            {
                deque.AddBack(i);
            }

            // Remove from front
            for (int i = 0; i < 5; i++)
            {
                deque.RemoveFront();
            }

            for (int i = 0; i < 5; i++)
            {
                deque.RemoveBack();
            }

            Console.WriteLine(deque.Count);
        }
    }
}
