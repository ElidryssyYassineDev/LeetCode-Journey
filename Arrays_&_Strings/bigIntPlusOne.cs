public class Solution {
    public int[] PlusOne(int[] digits) {
        int n=digits.Length;
        
        if (digits[n-1]!=9){//if the last digit is not 9, simply add 1 to it and return the array
            digits[n-1]+=1;
            return digits;
        }
        if(digits[n-1]==9){//if the last digit is 9, we need to check for carry
            for (int i=n-1;i>=0;i--){
                if(digits[i]+1==10){
                    digits[i]=0;
                }
                else{
                    digits[i]+=1;
                    return digits;
                }
            }
        }
        int[] result= new int[n+1];//if we have a carry from the most significant digit, we need to create a new array with an extra digit
        result[0]=1;
        return result;
    }
}