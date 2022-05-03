/*
 * @lc app=leetcode id=79 lang=csharp
 *
 * [79] Word Search
 */

// @lc code=start
public class Solution {
    bool[][] visited;

    public bool Exist(char[][] board, string word) {
        visited = new bool[board.Length][];

        for(int i =0; i<board.Length;i++){
            visited[i]= new bool[board[i].Length];
        }
        for(int i=0;i<board.Length;i++){
            for(int j=0;j<board[i].Length;j++){
                if(word[0]== board[i][j] && DFSSearch(board,word,0,i,j))
                    return true;
            }
        }
       return false;
    }
    public bool DFSSearch(char[][] board, string word, int wId, int row, int col){
        if(row <0 || row>=board.Length || col<0 || col>=board[0].Length || visited[row][col]) return false;
        if(board[row][col]!= word[wId]) return false;
        if(wId == word.Length-1) return true;
        visited[row][col] = true;
        if( DFSSearch(board,word,wId+1,row-1,col) ||
            DFSSearch(board,word,wId+1,row+1,col) ||
            DFSSearch(board,word,wId+1,row,col-1) ||
            DFSSearch(board,word,wId+1,row,col+1) ){
                return true;
            }
        visited[row][col] = false;    
        return false;
    }
}
// @lc code=end

