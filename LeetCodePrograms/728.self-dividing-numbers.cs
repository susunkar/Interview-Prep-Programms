/*
 * @lc app=leetcode id=728 lang=csharp
 *
 * [728] Self Dividing Numbers
 */

// @lc code=start
public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        
        List<int> selfDivNumbers = new List<int>();

        for(int i = left; i<= right; i++){
            if(IsSelfDivNumber(i)){
                selfDivNumbers.Add(i);
            }
        }
        return selfDivNumbers;
    }
    public bool IsSelfDivNumber(int num){

        int copyNumber = num;
        while (num>0){
            int degit = num % 10;
           
            if(degit==0 ||  (copyNumber % degit) != 0)return false;
            
            num = num/10;
        }
        return true;
    }
}
// @lc code=end

