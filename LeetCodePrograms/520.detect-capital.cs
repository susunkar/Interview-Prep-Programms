/*
 * @lc app=leetcode id=520 lang=csharp
 *
 * [520] Detect Capital
 */

// @lc code=start
public class Solution {
    public bool DetectCapitalUse(string word) {
        if(string.IsNullOrEmpty(word) || word.Length == 0 )    {
            return false;
        }
        int lowerCaseCount = 0;
        int upperCaseCount = 0;

        for (int i=0; i<word.Length; i++) {
            if((int)word[i] >= (int) 'a' && (int) word[i] <= (int) 'z'){
                lowerCaseCount++;
            }
            else if((int) word[i] >= (int) 'A' && (int) word[i] <= (int) 'Z'){
                upperCaseCount++;        
            }
        }
        return ((lowerCaseCount == word.Length) || 
                (upperCaseCount == word.Length) || 
                (char.IsUpper(word[0]) && lowerCaseCount == word.Length - 1));
    }
}
// @lc code=end

