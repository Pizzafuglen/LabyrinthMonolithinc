using System;

namespace TesterExample
{
    class Program
    {
        static void Main()
        {
            int[,] field =
            {
                { 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 1 }, 
                { 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1 },
                { 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1 }, 
                { 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 }, 
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1 }, 
                { 1, 0, 0, 0, 0, 1, 0, 1, 0, 1, 1 },
                { 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0 }, 
                { 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0 },
                { 1, 2, 1, 1, 0, 0, 0, 0, 0, 1, 0 }
            };

            Player player1 = new Player(0, 1, false, field);
            Field field1 = new Field(field);

            field1.ShowFieldFull();
            player1.HandleMovement();
        }
    }
}