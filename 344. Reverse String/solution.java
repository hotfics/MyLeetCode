public class Main {

    public static void main(String[] args) {

       String s= reverseString("abc");
        System.out.println(s);
    }
    public static String reverseString(String s) {
        char[] cs= s.toCharArray();
        for ( int i=0;i<cs.length;i++){
            if (i<cs.length-1-i)
            swap(cs,i,cs.length-1-i);
        }
       return  new String(cs);
    }
    public static   void swap(char[] cs,int i,int j){
        char tmp;
        tmp=cs[i];
        cs[i]=cs[j];
        cs[j]=tmp;
    }
}
