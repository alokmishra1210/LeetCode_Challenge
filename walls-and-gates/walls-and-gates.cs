public class Solution {
    public void WallsAndGates(int[][] rooms) {
        if (rooms == null || rooms.Length == 0 || rooms[0].Length == 0) {
            return;
        }

        int m = rooms.Length;
        int n = rooms[0].Length;
        Queue<(int, int)> queue = new Queue<(int, int)>();

        // Start BFS from every gate
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (rooms[i][j] == 0) {
                    queue.Enqueue((i, j));
                }
            }
        }

        // Directions: up, down, left, right
        int[][] dirs = new int[][] { new int[]{-1, 0}, new int[]{1, 0}, new int[]{0, -1}, new int[]{0, 1} };

        while (queue.Count > 0) {
            var cell = queue.Dequeue();
            int row = cell.Item1;
            int col = cell.Item2;

            foreach (var dir in dirs) {
                int newRow = row + dir[0];
                int newCol = col + dir[1];

                // Check bounds and if it's an empty room
                if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n && rooms[newRow][newCol] == int.MaxValue) {
                    rooms[newRow][newCol] = rooms[row][col] + 1;
                    queue.Enqueue((newRow, newCol));
                }
            }
        }
       

    }
}