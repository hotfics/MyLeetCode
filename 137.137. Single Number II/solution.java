import java.util.*;

public class Main {

    public static void main(String[] args) {
          int[] nums =  {43,16,45,89,45,-2147483648,45,2147483646,-2147483647,-2147483648,43,2147483647,-2147483646,-2147483648,89,-2147483646,89,-2147483646,-2147483647,2147483646,-2147483647,16,16,2147483646,43
};

     int value=   singleNumber(nums);
        System.out.println(value);

    }
    public static int singleNumber(int[] nums) {
        Map<Integer,Integer> map=new HashMap<>();
        for (int i=0;i<nums.length;i++){
            if (!map.containsKey(nums[i])){
                map.put(nums[i],1);
            }
            else
            {
                if (map.get(nums[i])!=2){
                    map.put(nums[i],2);

                }
                else
                {
                    map.remove(nums[i]);
                }
            }
        }
        int value=0;
      for (Map.Entry<Integer,Integer> entry: map.entrySet()){
            value= entry.getKey();
      }
        return value;
    }

}