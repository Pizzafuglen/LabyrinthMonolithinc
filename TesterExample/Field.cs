using System;
namespace TesterExample
{
    public class Field
    {
        private int[,] fieldArray;

        private int currentPlayerX;
        private int currentPlayerY;

        public Field(int[,] fieldArray)
        {
            this.fieldArray = fieldArray;
            int playerX = this.currentPlayerX;
            int playerY = this.currentPlayerY;
        }

        public void ShowFieldFull()
        {
            for (int i = 0; i < this.fieldArray.GetLength(0); i++)
            {
                for (int j = 0; j < this.fieldArray.GetLength(1); j++)
                {
                    Console.Write(this.fieldArray[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}