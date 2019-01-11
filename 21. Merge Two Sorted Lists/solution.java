/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
class Solution {
private static class ListNodeCompare implements Comparator<ListNode> {
        @Override
        public int compare(ListNode o1, ListNode o2) {
            if (o1.val > o2.val) return 1;
            else if (o1.val < o2.val) return -1;
            return 0;
        }
    }
   public  ListNode mergeTwoLists(ListNode l1, ListNode l2) {
       if(l1==null && l2==null) return null;
        List<ListNode> list = new ArrayList<>();
        if (l1!=null){
            while (l1.next != null) {
                list.add(new ListNode(l1.val));
                l1 = l1.next;
            }
            list.add(new ListNode(l1.val));
        }
      if (l2!=null){
          while (l2.next != null) {
              list.add(new ListNode(l2.val));
              l2 = l2.next;
          }
          list.add(new ListNode(l2.val));
      }
        java.util.Collections.sort(list, new ListNodeCompare());
        for (int i = 0; i < list.size(); i++) {
            if (i == list.size() - 1) {
                list.get(i).next = null;

            } else {
                list.get(i).next = list.get(i + 1);

            }
        }
        return list.get(0);
    }
}