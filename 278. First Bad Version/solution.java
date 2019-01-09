/* The isBadVersion API is defined in the parent class VersionControl.
      boolean isBadVersion(int version); */

public class Solution extends VersionControl {
    public int firstBadVersion(int n) {
         int first=0; int last=n-1;
        while (first<last){
            int mid=first +(last-first)/2;
            if (isBadVersion(mid+1)==false) first=mid+1;
            else last=mid;
        }
        return first+1;   
    }
}