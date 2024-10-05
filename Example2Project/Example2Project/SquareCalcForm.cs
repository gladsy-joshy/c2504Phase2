using System;
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
    public partial class SquareCalcForm : Form
    {
        public SquareCalcForm()
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

       

        private void btnFindSquare_Click(object sender, EventArgs e)
        {
            if (!IsNum(txtNumber1.Text))
            {
                MessageBox.Show("Please enter number only.");
                txtNumber1.Focus();
                txtNumber1.SelectAll();
                return;
            }
            int number = int.Parse(txtNumber1.Text);
            int square = (int)Math.Pow(number, 2);
            txtSquare.Text = square.ToString();
        }
    }
}

