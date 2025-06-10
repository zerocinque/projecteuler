public class Problem015{
    public string Run(){
        var matrixSize = 20; // 20x20 grid
        var gridSize = matrixSize + 1; // 21x21 grid
        var grid = new long[gridSize, gridSize];
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                if (i == 0 || j == 0)
                {
                    grid[i, j] = 1; // First row and first column are initialized to 1
                }
                else
                {
                    grid[i, j] = (grid[i - 1, j] + grid[i, j - 1]); // Sum of top and left cells
                }
            }
        }

        return grid[matrixSize, matrixSize].ToString(); // Return the number of paths to the bottom-right corner
    }
}