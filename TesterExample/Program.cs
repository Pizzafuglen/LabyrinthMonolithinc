using System;

namespace TesterExample
{
    class Program
    {
        //The current next step is to find out how precisely I am going to implement it checking movement

        static void Main()
        {
            int[,] field =
            {
                { 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
                { 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 }, 
                { 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1 },
                { 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
                { 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1 }, 
                { 1, 0, 0, 0, 0, 1, 1, 1, 0, 1, 1 },
                { 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1 }, 
                { 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1 },
                { 1, 2, 1, 1, 0, 0, 0, 0, 0, 1, 1 }
            };

            Player player1 = new Player(0, 1, false);

            Player.ShowField(field);
            player1.HandleMovement(field);
        }
    }
}