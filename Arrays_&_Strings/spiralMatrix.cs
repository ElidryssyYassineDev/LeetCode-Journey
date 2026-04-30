public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        int m=matrix.Length;
        int n=matrix[0].Length;
        
        IList<int> spiralList = new List<int>();
        int top=0;
        int left=0;
        int right=n-1;
        int bottom=m-1;
        
        while(top<=bottom && left<=right){
            //left ---> right sweep : top++
            for(int i=left;i<=right;i++){
                spiralList.Add(matrix[top][i]);
            }
            top++;
            
            //top ---> down sweep :right--
            for(int i=top;i<=bottom;i++){
                spiralList.Add(matrix[i][right]);
            }
            right--;
            
            //right ---> left sweep : bottom--
            if(top<=bottom){
                for(int i=right;i>=left;i--){
                    spiralList.Add(matrix[bottom][i]);
                }
                bottom--;
            }
            //down ---> top sweep :left++
            if(left<=right){
                for(int i=bottom;i>=top;i--){
                    spiralList.Add(matrix[i][left]);
                }
                left++;
            }
            
        }
        return spiralList;
    }
}