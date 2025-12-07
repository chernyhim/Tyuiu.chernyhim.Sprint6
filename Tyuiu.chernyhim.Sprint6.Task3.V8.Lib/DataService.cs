using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.chernyhim.Sprint6.Task3.V8.Lib
{
    public class DataService : ISprint6Task3V8
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int[,] mat = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0 && i == 3)
                    {
                        mat[i, j] = 0;
                    }
                    else
                    {
                        mat[i,j]=matrix[i,j];
                    }
                }
            }
            return mat;
        }
    }
}