/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
     System.Collections.Stack stkOpenParentheses = new System.Collections.Stack()    ;
     bool expression = true;
     foreach(var p in s.ToCharArray()){
         switch (p) {
            case '(':
            case '{':
            case '[': stkOpenParentheses.Push(p);
                      break;
            case ')':
            case '}':
            case ']': 
                    char openParenthe = ' ';
                    if(stkOpenParentheses.Count<= 0){
                        expression = false;
                        break;
                    }
                    openParenthe =(char) stkOpenParentheses.Pop();
                    if(expression && (( openParenthe == '(' && p == ')') || 
                        ( openParenthe == '[' && p == ']') ||  
                        ( openParenthe == '{' && p == '}'))){
                         expression = true;
                    }
                    else {
                         expression = false;
                    }
                    break;
            default: break;
         }
     }
     if(stkOpenParentheses.Count == 0 && expression){
         return true;
     }
     else{
         return false;
     }
    }
}
// @lc code=end

