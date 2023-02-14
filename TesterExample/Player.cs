using System;
namespace TesterExample
{
    public class Player
    {
        private int playerX;
        private int playerY;

        private bool winCon;

        public Player(int playerX, int playerY, bool winCon)
        {
            this.playerX = playerX;
            this.playerY = playerY;
            this.winCon = winCon;
        }
        public void HandleMovement(int[,] field)
        {
            this.winCon = false;
            while (this.winCon != true)
            {
                string input = Console.ReadLine();

                if (input.Equals("w"))
                {
                    if (this.playerX >= 0)
                    {
                        if (field[this.playerX - 1, this.playerY] == 0)
                        {
                            this.playerX -= 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid input");
                    }
                }
                else if (input.Equals("s"))
                {
                    if (this.playerX >= 0)
                    {
                        if (field[this.playerX + 1, this.playerY] == 0)
                        {
                            this.playerX += 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid input");
                    }
                }
                else if (input.Equals("a"))
                {
                    if (this.playerY >= 0)
                    {
                        if (field[this.playerX, this.playerY - 1] == 0)
                        {
                            this.playerY -= 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid input");
                    }
                }
                else if (input.Equals("d"))
                {
                    if (this.playerY >= 0)
                    {
                        if (field[this.playerX, this.playerY + 1] == 0)
                        {
                            this.playerY += 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("This is out of bounds");
                    }
                }

                Console.WriteLine("playerX: " + this.playerY + " playerY: " + this.playerX);
                if (field[this.playerX,this.playerY] == 2)
                {
                    Console.WriteLine("You have won!");
                    this.winCon = true;
                }
            }
        }
        public static void ShowField(int[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}