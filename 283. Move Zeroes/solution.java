class Solution {
    public void moveZeroes(int[] nums) {
     if (nums.length==0) return ;
        if( noneZero(nums)) return ;
        while (check(nums)==false){
            for (int i=0;i<nums.length;i++){
                if (nums[i]==0){
                    for (int j=i;j<nums.length-1;j++){
                        swap(nums,j,j+1);
                    }
                }
            }
        }
    }
    private    boolean noneZero(int[] nums){
        for (int i=0;i<nums.length;i++){
            if (nums[i]==0) return false;
        }
        return true;
    }
    private    boolean check(int[] nums){
        if (nums[nums.length-1]!=0) return  false;
        for (int i=0;i<nums.length;i++){
            if ((nums[i]==0)){
                while (i< nums.length-1){
                    if (nums[i++]!=0) return false;
                }
            }
        }
        return  true;
    }
    private   void swap(int[] array, int a ,int b ){
        int tmp;
        tmp=array[a];
        array[a]=array[b];
        array[b]=tmp;
    }
}