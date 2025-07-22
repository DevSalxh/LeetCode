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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) { 
      // ListNode to save the summation of the digit of nth node 
        ListNode result = new();
      // ListNode that point the head
        ListNode head = result;
        int sum = 0;
        while(l1 != null || l2 != null || sum > 0)
        {
            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }
            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

          //  Add new node to the LL but the value gonna be { 0 - 9 } [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
            result.next = new ListNode(sum % 10);
            sum /= 10 ;
            result = result.next;
        }
        return head.next;

    }
}
