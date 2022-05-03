/*
 * @lc app=leetcode id=832 lang=csharp
 *
 * [832] Flipping an Image
 */

// @lc code=start
public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        for(int r =0; r<image.Length;r++){
            int low = 0;
            int high = image[r].Length - 1;
            while (low < high)
            {
                int temp = image[r][high];
                image[r][high] = image[r][low];
                image[r][low] = temp;
                low++;
                high--;
            }
            for (int c = 0; c < image[r].Length; c++)
            {
                if (image[r][c] == 1) image[r][c] = 0;
                else image[r][c] = 1;
            }
        }
        return image;
    }
}
// @lc code=end

