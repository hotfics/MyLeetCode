import java.util.HashSet;
import java.util.Set;

public class Main {

    public static void main(String[] args) {
      int[] testArray={1,2,3,4,5,5,6,11};
      int[] testArray1={1,2,3,4,5,6,11};
      boolean b=containsDuplicate(testArray);
      boolean b1=containsDuplicate(testArray1);
        System.out.println(b);
        System.out.println(b1);
    }
    public  static boolean containsDuplicate(int[] array){
        Set set=new HashSet();
        for(int i : array){
            set.add(i);
        }
        int arrayLen=array.length;
        int setLen=set.size();
        if (setLen<arrayLen)
            return true;
        else
            return false;
    }
}
