public class Solution {
    public int NumIslands(char[][] grid) {
        
   if (grid == null || grid.Length == 0) {
            return 0;
        }

        int numIslands = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == '1') {
                    numIslands++;
                    MarkIsland(grid, i, j, rows, cols);
                }
            }
        }

        return numIslands;
    }

    private void MarkIsland(char[][] grid, int i, int j, int rows, int cols) {
        if (i < 0 || j < 0 || i >= rows || j >= cols || grid[i][j] != '1') {
            return;
        }

        grid[i][j] = '2'; // Mark as visited

        // Explore all four directions
        MarkIsland(grid, i - 1, j, rows, cols); // up
        MarkIsland(grid, i + 1, j, rows, cols); // down
        MarkIsland(grid, i, j - 1, rows, cols); // left
        MarkIsland(grid, i, j + 1, rows, cols); // right
    }
}