public class Solution {
    public bool IsValidSudoku(char[][] board) {
        List<HashSet<char>> horiz = new();
        List<HashSet<char>> vert = new();
        List<HashSet<char>> sqrt = new();

        for (int i = 0; i < 9; i++) {
            vert.Add(new HashSet<char>());
            horiz.Add(new HashSet<char>());
            sqrt.Add(new HashSet<char>());
        }

        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                if (board[i][j] != '.') {
                    if (!horiz[i].Add(board[i][j]) || !vert[j].Add(board[i][j]) ||
                        !sqrt[(i / 3) * 3 + (j / 3)].Add(board[i][j]))
                        return false;
                }
            }
        }
        return true;
    }
}
