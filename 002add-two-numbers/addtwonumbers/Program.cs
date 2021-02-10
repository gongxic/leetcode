using System;

namespace addtwonumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}



// Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}



public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var newListNode = new ListNode();
        if (l1 != null && l2 != null)
        {
            newListNode.val = l1.val + l2.val;
            if (newListNode.val >= 10)
            {
                newListNode.val = newListNode.val - 10;
                if (l1.next == null)
                {
                    l1.next = new ListNode { val = 1 };
                }
                else
                {
                    l1.next.val = l1.next.val + 1;
                }

                newListNode.next = AddTwoNumbers(l1.next, l2.next);
            }
            else
            {
                newListNode.next = AddTwoNumbers(l1.next, l2.next);
            }

        }
        else if (l1 != null)
        {
            if (l1.val >= 10)
            {
                newListNode.val = l1.val - 10;
                if (l1.next == null)
                {
                    l1.next = new ListNode { val = 1 };
                }
                else
                {
                    l1.next.val = l1.next.val + 1;
                }
            }
            else
            {
                newListNode.val = l1.val;
            }

            newListNode.next = AddTwoNumbers(l1.next, null);
        }
        else if (l2 != null)
        {
            if (l2.val >= 10)
            {
                newListNode.val = l2.val - 10;
                if (l1.next == null)
                {
                    l2.next = new ListNode { val = 1 };
                }
                else
                {
                    l2.next.val = l2.next.val + 1;
                }

            }
            else
            {
                newListNode.val = l2.val;
            }
            newListNode.val = l2.val;
            newListNode.next = AddTwoNumbers(l2.next, null);
        }
        else if (l1 == null && l2 == null)
        {
            return l1;
        }

        return newListNode;
    }
}
