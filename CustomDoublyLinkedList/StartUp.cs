using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main()
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();

            for (int i = 1; i <= 10; i++)
            {
                doublyLinkedList.AddFirst(i);
            }

            int[] arr = doublyLinkedList.ToArray();
            
        }
    }
}
