
public class Main {
    private static void selectionSort(int[] array){
        for (int i=0;i<array.length;i++){
            int k=i;
            for (int j=i+1;j<array.length;j++){
                if (array[j]<array[k]){
                    k=j;
                }
                if (i != k){
                        int tmp=array[i];
                        array[i]=array[k];
                        array[k]=tmp;
                }
            }
        }
    }
    public  static  void main(String[] s ){
        int[] array={5,2,8,4,9,1};
        selectionSort(array);
        for (int a:
           array ){
            System.out.println(a);

        }
    }
}
