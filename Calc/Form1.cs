﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void AddToBoard(string a)
        //{
        //    board.Text += a;
        //}



        private void number1_click(object sender, EventArgs e)
        {
            TextBox _board = board;
            Input.AddToBoard("1", _board);
        }

        private void number2_Click(object sender, EventArgs e)
        {
            TextBox _board = board;
            Input.AddToBoard("2", _board);
        }

        private void number3_Click(object sender, EventArgs e)
        {
            TextBox _board = board;
            Input.AddToBoard("3", _board);
        }

        private void number4_Click(object sender, EventArgs e)
        {
            TextBox _board = board;
            Input.AddToBoard("4", _board);
        }

        private void number5_Click(object sender, EventArgs e)
        {
            TextBox _board = board;
            Input.AddToBoard("5", _board);
        }

        private void number6_Click(object sender, EventArgs e)
        {
            TextBox _board = board;
            Input.AddToBoard("6", _board);
        }

        private void number7_Click(object sender, EventArgs e)
        {
            TextBox _board = board;
            Input.AddToBoard("7", _board);
        }

        private void number8_Click(object sender, EventArgs e)
        {
            TextBox _board = board;
            Input.AddToBoard("8", _board);
        }

        private void number9_Click(object sender, EventArgs e)
        {
            TextBox _board = board;
            Input.AddToBoard("9", _board);
        }

        private void number0_Click(object sender, EventArgs e)
        {
            TextBox _board = board;
            Input.AddToBoard("0", _board);
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            TextBox _board = board;
            Input.AddToBoard(",", _board);
        }

        private void swapSign_Click(object sender, EventArgs e)
        {
            TextBox _board = board;
            Input.swapSign(_board);
        }

        private void add_Click(object sender, EventArgs e)
        {
            Input.Add(board);
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            Input.Subtract(board);
        }

        private void multiplicate_Click(object sender, EventArgs e)
        {
            Input.Multiply(board);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            Input.Divide(board);
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (Input.operatorFlag == true && Input.firstNumber != 0)
            {
                Input.sign.DoMath(Input.firstNumber, board);
            }
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Input.Clear(board);
        }
    }
}
