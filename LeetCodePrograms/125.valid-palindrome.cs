/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder text = new StringBuilder();
        for(int i = 0; i<s.Length;i++){
           if(char.IsLetterOrDigit(s[i])){
               text.Append(char.ToLower(s[i]));
           }
       }
       int leftIdx = 0;
       int rightIdx = text.Length-1;

       while(leftIdx<text.Length-1/2){
           if(text[leftIdx] != text[rightIdx]){
               return false;
           }
           leftIdx++;
           rightIdx--;
       }
        return true;
    }
}
// @lc code=end

