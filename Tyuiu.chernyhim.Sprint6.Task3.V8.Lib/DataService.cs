using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.chernyhim.Sprint6.Task3.V8.Lib
{
    public class DataService : ISprint6Task3V8
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] row = new int[5];

            for (int i = 0; i <= 4; i++)
            {
                if (matrix[4,i] % 2 != 0)
                {
                    row[i] = matrix[4, i];
                }
                else
                {
                    row[i] = 0;
                }                
            }           

            for (int i = 0; i <= 4; i++)
            {
                matrix[4, i] = row[i];
            }

            return matrix;
        }


    }
}