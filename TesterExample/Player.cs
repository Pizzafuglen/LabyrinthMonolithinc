using System;
using System.Runtime.CompilerServices;

namespace TesterExample
{
    public class Player
    {
        private int playerX;
        private int playerY;

        private bool winCon;

        private int[,] field;

        public Player(int playerX, int playerY, bool winCon, int[,] field)
        {
            this.playerX = playerX;
            this.playerY = playerY;
            this.winCon = winCon;
            this.field = field;
        }
        public void HandleMovement()
        {
            this.winCon = false;
            ShowFieldPlayer();
            while (this.winCon != true)
            {
                string input = Console.ReadLine();

                switch (input)
                {
                    case "w" :
                        HandleUp();
                        break;
                    case "s" :
                        HandleDown();
                        break;
                    case "a" :
                        HandleLeft();
                        break;
                    case "d" :
                        HandleRight();
                        break;
                }

                //Console.WriteLine("playerX: " + this.playerY + " playerY: " + this.playerX);
                ShowFieldPlayer();
                if (winCon)
                {
                    Console.WriteLine("You have won!");
                }
            }
        }
        private void ShowFieldPlayer()
        {
            for (int i = 0; i < this.field.GetLength(0); i++)
            {
                for (int j = 0; j < this.field.GetLength(1); j++)
                {
                    if (field[this.playerX, this.playerY] != field[i,j])
                    {
                        Console.Write(field[i,j] + " ");
                    }
                    else
                    {
                        field[this.playerX, this.playerY] = 9;
                        Console.Write(field[i,j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        private void HandleUp()
        {
            if (this.playerX >= 0 && this.field[this.playerX - 1, this.playerY] != null)
            {
                if (this.field[this.playerX - 1, this.playerY] == 0)
                {
                    this.playerX -= 1;
                    field[this.playerX + 1 , this.playerY] = 0;
                }
                else if (this.field[this.playerX - 1, this.playerY] == 2)
                {
                    this.playerX -= 1;
                    field[this.playerX + 1 , this.playerY] = 0;
                    Console.WriteLine("You have won!");
                    this.winCon = true;
                }
                else
                {
                    Console.WriteLine("This is out of bounds");
                }
            }
            else
            {
                Console.WriteLine("This is out of bounds");
            }
            Console.Clear();
        }

        private void HandleDown()
        {
            if (this.playerX >= 0 && this.field[this.playerX + 1, this.playerY] != null)
            {
                if (this.field[this.playerX + 1, this.playerY] == 0)
                {
                    this.playerX += 1;
                    field[this.playerX - 1, this.playerY] = 0;
                }
                else if (this.field[this.playerX + 1, this.playerY] == 2)
                {
                    this.playerX += 1;
                    field[this.playerX - 1 , this.playerY] = 0;
                    Console.WriteLine("You have won!");
                    this.winCon = true;
                }
                else
                {
                    Console.WriteLine("This is out of bounds");
                }
            }
            else
            {
                Console.WriteLine("This is out of bounds");
            }
            Console.Clear();
        }

        private void HandleLeft()
        {
            if (this.playerY >= 0 && this.field[this.playerX, this.playerY - 1] != null)
            {
                if (this.field[this.playerX, this.playerY - 1] == 0)
                {
                    this.playerY -= 1;
                    field[this.playerX, this.playerY + 1] = 0;
                }
                else if (this.field[this.playerX, this.playerY  - 1] == 2)
                {
                    this.playerY -= 1;
                    field[this.playerX , this.playerY + 1] = 0;
                    Console.WriteLine("You have won!");
                    this.winCon = true;
                }
                else
                {
                    Console.WriteLine("This is out of bounds");
                }
            }
            else
            {
                Console.WriteLine("This is out of bounds");
            }
            Console.Clear();
        }

        private void HandleRight()
        {
            if (this.playerY >= 0 && this.field[this.playerX, this.playerY + 1] != null)
            {
                if (this.field[this.playerX, this.playerY + 1] == 0)
                {
                    this.playerY += 1;
                    field[this.playerX, this.playerY - 1] = 0;
                }
                else if (this.field[this.playerX, this.playerY + 1] == 2)
                {
                    this.playerY += 1;
                    field[this.playerX , this.playerY - 1] = 0;
                    Console.WriteLine("You have won!");
                    this.winCon = true;
                }
                else
                {
                    Console.WriteLine("This is out of bounds");
                }
            }
            else
            {
                Console.WriteLine("This is out of bounds");
            }
            Console.Clear();
        }
    }
}