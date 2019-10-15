﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego4enRaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GameForm_MouseClick()
        {
            int columnIndex = this.ColumnNumber(e.Location);

            if (columnIndex != -1)
            {

                int rowIndex = this.EmptyRow(columnIndex);

                if (rowIndex != -1)
                {

                    this.board[rowIndex, columnIndex] = this.turn;
                    if (this.turn == 1)
                    {

                        Graphics g = this.CreateGraphics();
                        g.FillEllipse(Brushes.Red, 32 + 48 * columnIndex, 32 + 48 * rowIndex, 32, 32);

                    }
                    else
                    {

                        if (this.turn == 2)
                        {

                            Graphics g = this.CreateGraphics();
                            g.FillEllipse(Brushes.Green, 32 + 48 * columnIndex, 32 + 48 * rowIndex, 32, 32);

                        }

                    }

                    if (this.turn == 1)
                    {
                        this.turn = 2;
                    }
                    else
                    {
                        this.turn = 1;
                    }

                }

            }

        }

        private int winnerPlayer()
        {
            // vertical win check
            for (int row = 0; row < this.board.GetLength(0) - 3; row++)
            {

                for (int col = 0; col < this.board.GetLength(i); col++)
                {

                    if (this.AllNumberEqual(playertoCheck, this.board[row, col], this.board[row + 1, col], this.board[row + 2, col], this.board[row + 3, col]))
                    {
                        return playerToCheck;
                    }

                }

            }

            //horizontal win check
            for (int row = 0; row < this.board.GetLength(0); row++)
            {
            }
            return -1;
        }
        private bool AllNumberEqual(int toCheck, params int[] numbers)
        {

            foreach (int num in numbers)
            {

                if (num != toCheck)
                {
                    return false;
                }

            }

            return true;

        }

        private int ColumnNumber(Point mouse)
        {
            for (int i = 0; this.boardColumns.Length; i++)
            {
                if ((mouse.X >= this,boardColumns[i].X ) && (mouse.Y >= this.boardColumns[i].Y))
                {

                if ((mouse.X <= this.boardColumnsp[i].X + this.boardColumns[i].Width) && (mouse.Y <= this.boardColumns[i].Y + this.boardColumns[i].Height)) //verificar si el cod es correcto
                {

                }
            }
        }
    }
    private void Form1_Load(object sender, EventArgs e)
    {

    }


}
