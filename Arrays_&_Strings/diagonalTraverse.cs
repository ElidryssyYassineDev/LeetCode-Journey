public class Solution {
    public int[] FindDiagonalOrder(int[][] mat) {
        int m = mat.Length;
        int n = mat[0].Length;

        // Each cell (row, col) belongs to diagonal number (row + col)
        // Total number of diagonals in an m x n matrix is m + n - 1
        List<List<int>> diagonals = new List<List<int>>();
        for (int i = 0; i < m + n - 1; i++) {
            diagonals.Add(new List<int>());
        }

        // Group every element into its corresponding diagonal bucket
        for (int row = 0; row < m; row++) {
            for (int col = 0; col < n; col++) {
                int d = row + col;
                diagonals[d].Add(mat[row][col]);
            }
        }

        int[] res = new int[m * n];
        int index = 0;

        for (int d = 0; d < diagonals.Count; d++) {
            List<int> diag = diagonals[d];

            // Even diagonals go bottom-left → top-right, so we reverse
            // Odd diagonals go top-right → bottom-left, which is already the natural insertion order
            if (d % 2 == 0) {
                diag.Reverse();
            }

            // Flatten the diagonal into the result array
            foreach (int val in diag) {
                res[index++] = val;
            }
        }
        return res;
    }
}