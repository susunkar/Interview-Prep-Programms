/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
public class Solution {
    public int[] PlusOne(int[] digits) {
        List<int> sum = new List<int>();
       
        int carry = 0;
        sum.Add(0);

        if(digits.Length ==1) {
                digits[0] = digits[0] + 1;
                if(digits[0]>9){
                    sum[0] = digits[0]/10;
                    digits[0] = digits[0]%10;
                    sum.AddRange(digits);
                    return sum.ToArray();
                }
                return digits;
        }
       
        for(int i= digits.Length-1; i>0 ;i--){
            if(i == digits.Length -1){
                digits[i] +=1;
            } 
            else 
            {
                digits[i]+= carry;
                carry =0;
            }
            if(digits[i] >9) {
                carry = digits[i]/10;
                digits[i] = digits[i]%10;
            }
            if(carry == 0 ) break;
        }
        
        if((digits[0] + carry) > 9)
        {
             digits[0] = digits[0] + carry;
             sum[0] = digits[0]/10;
             digits[0] = digits[0]%10;
             sum.AddRange(digits);
             return sum.ToArray();
        }
        else{
            digits[0] = digits[0] + carry;
        }
        return digits;
    }
}
// @lc code=end

