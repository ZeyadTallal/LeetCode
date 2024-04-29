/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        int count = 1 ; 
        int middle = 0 ;
        ListNode x= head;
        while(x.next != null)
        {
            count ++;
            x = x.next;
        }
        if(count%2 == 0)
        {
            Console.WriteLine(count);
            middle = (int)Math.Ceiling(count / 2.0);
            Console.WriteLine(middle);
        }
        else
        {
            Console.WriteLine(count);
            middle = (int)Math.Ceiling(count / 2.0)-1;
            Console.WriteLine(middle);
        }
        for(int i = 1 ; i <= middle ; i++)
        {
            head = head.next;
        }
        return head;
    }
}