﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example2Project
{
    public partial class SumCalcForm : Form
    {
        public SumCalcForm()
        {
            InitializeComponent();
        }
        private bool IsNum(string numStr)
        {
            try
            {
                int.Parse(numStr);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        private void btnFindSum_Click_1(object sender, EventArgs e)
        {
            if (!IsNum(txtNumber1.Text))
            {
                MessageBox.Show("Number 1 is not a number");
                txtNumber1.Focus();
                txtNumber1.SelectAll();
                return;
            }
            if (!IsNum(txtNumber2.Text))
            {
                MessageBox.Show("Number 2 is not a number");
                txtNumber2.Focus();
                txtNumber2.SelectAll();
                return;
            }

            int number1 = int.Parse(txtNumber1.Text);
            int number2 = int.Parse(txtNumber2.Text);
            int sum = number1 + number2;
            txtSum.Text = sum.ToString();
        }

        private void SumCalcForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
