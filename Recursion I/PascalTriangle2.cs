public class Solution {
    public IList<int> GetRow(int rowIndex) {
        if (rowIndex == 0) return new List<int>{1};
        
        var curRow = new List<int>{1};
        var prevRow = GetRow(rowIndex - 1);
        
        for (int i = 1; i < rowIndex; ++i){
            curRow.Add(prevRow[i - 1] + prevRow[i]);
        }
        
        curRow.Add(1);
        return curRow;
    }
}