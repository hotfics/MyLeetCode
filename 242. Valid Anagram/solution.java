import java.util.*;

public class Main {
    public static void main(String[] args) {

    }

    public static boolean isAnagram(String s, String t) {
        if (s.length()!=t.length()) return false;
        Set<Character> s1=new TreeSet<>();
        Set<Character> t1=new TreeSet<>();
        for (int i=0;i<s.length();i++){
            s1.add(s.charAt(i));
        }
        for (int j=0;j<t.length();j++){
            t1.add(t.charAt(j));
        }
        if (s1.size()!=t1.size()) return  false;
        Iterator<Character> it=s1.iterator();
        Map<Character,Integer> map1=new HashMap<>();
        while (it.hasNext()){
            Character c=it.next();
            int count=charactorOccurNum(s,c);
            map1.put(c,count);

        }
        Iterator<Character> it1=t1.iterator();
        Map<Character,Integer> map2=new HashMap<>();
        while (it1.hasNext()){
            Character c=it1.next();
            int count=charactorOccurNum(t,c);
            map2.put(c,count);

        }
        if (map1.equals(map2)) return true;
        else  return  false;

    }
    private  static int charactorOccurNum(String s,Character c){
        int number=0;
        for (int i=0;i<s.length();i++){
            if (c.equals(s.charAt(i))){
                number=number+1;
            }
        }
        return  number;
    }

}
