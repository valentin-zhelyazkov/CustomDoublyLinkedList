using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode(element);
                
            }
            else
            {
                ListNode newHead = new ListNode(element);
                ListNode oldHead = this.head;

                this.head = newHead;
                oldHead.PreviousNode = newHead;
                newHead.NextNode = oldHead;
            }
            this.Count++;
        }
        public void AddLast(int element)
        {
            if(this.Count == 0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                ListNode newTail = new ListNode(element);
                ListNode oldTail = this.tail;

                this.tail = newTail;
                oldTail.NextNode = newTail;
                newTail.PreviousNode = oldTail;
            }
            this.Count++;
        }
        public int RemoveFirst()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException("List is empty!");
            }
            else if(this.Count == 1)
            {
                this.head = null;
                this.tail = null;

            }
            else
            {
                ListNode newHead = this.head;
            }
            this.Count--;
            return 0;
        }
    }
}
