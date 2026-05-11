public class Solution {
    public void ReverseString(char[] s) {
        int N=s.Length;
        int i=0;
        int j=N-1;
        char temp;
        while(i<j){
            temp=s[i];
            s[i]=s[j];
            s[j]=temp;
            i++;
            j--;
        }
        
     
    }
}