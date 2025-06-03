using System.Data;

namespace LeetCodes;

public class Graphs
{
    public int NumIslands(char[][] grid)
    {
        if (grid == null || grid.Length == 0)
        {
            return 0;
        }
    
        var visited = new HashSet<(int, int)>();
        int rows = grid.Length;
        int cols = grid[0].Length;
        int islands = 0;

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (grid[r][c] == '1' && !visited.Contains((r, c)))
                {
                    dfs(r, c, visited, rows, cols, grid);
                    islands++;
                }
            }
        }
        return islands;
    }

    private void dfs(int row, int col, HashSet<(int, int)> visited, int rows, int cols, char[][] grid)
    {
        if (row < 0 || row >= rows || col < 0 || col >= cols || 
            visited.Contains((row, col)) || 
            grid[row][col] != '1')
        {
            return;
        }
    
        visited.Add((row, col));
        dfs(row + 1, col, visited, rows, cols, grid);
        dfs(row - 1, col, visited, rows, cols, grid);
        dfs(row, col + 1, visited, rows, cols, grid);
        dfs(row, col - 1, visited, rows, cols, grid);
    }

}