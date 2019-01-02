public class Solution {
    public bool IsValid(string s) {
      if (s == null ||s.Length==0) return true;
            if (s.Length % 2 != 0) return false;
			char bigLeft = '{';
            char bigRigth = '}';
            char midLeft = '[';
            char midRight = ']';
            char smallLeft = '(';
            char smallRight = ')';

            if ((s.Length==2))
            {
                if ((s[0] == smallLeft && s[1] == smallRight) || (s[0] == midLeft && s[1] == midRight) ||(s[0] == bigLeft && s[1] == bigRigth))
                {
                    return true;
                }
                else {      return false;}
            }
           
            char[] chars=  s.ToCharArray();
            for (int i = 0; i < chars.Length-1; i++)
            {
                
                if( (chars[i]==bigLeft)&&(chars[i+1]==bigRigth)|| (chars[i] == midLeft) && (chars[i + 1] == midRight)|| (chars[i] == smallLeft) && (chars[i + 1] == smallRight))
                {
                    return IsValid( s.Substring(0, i) + s.Substring(i + 2, s.Length-i-1-1)  );
                }
            }
            return false;
    }
}