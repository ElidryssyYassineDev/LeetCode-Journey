public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] help = new int[m];

        // copy nums1
        for (int i = 0; i < m; i++) {
            help[i] = nums1[i];
        }

        int iPointer = 0, jPointer = 0, k = 0;

        // merge
        while (iPointer < m && jPointer < n) {
            if (help[iPointer] <= nums2[jPointer]) {
                nums1[k++] = help[iPointer++];
            } else {
                nums1[k++] = nums2[jPointer++];
            }
        }

        // remaining elements
        while (iPointer < m) {
            nums1[k++] = help[iPointer++];
        }

        while (jPointer < n) {
            nums1[k++] = nums2[jPointer++];
        }
    }
}