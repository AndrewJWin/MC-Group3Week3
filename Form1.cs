using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (password.Length >= 16 && password.Any(char.IsDigit) && password.Any(char.IsUpper) && password.Any(char.IsPunctuation)) {

                lblResult.Text = "Best";
                lblResult.BackColor = Color.Green;
            }
            else if (password.Length >= 10 && password.Any(char.IsDigit) && password.Any(char.IsUpper)) {
                lblResult.Text = "Good";
                lblResult.BackColor = Color.LightBlue;
            }
            else if (password.Length >= 10 && (password.Any(char.IsDigit) || password.Any(char.IsUpper))) {
                lblResult.Text = "Fair";
                lblResult.BackColor = Color.LightYellow;
            } else {
                lblResult.Text = "Bad";
                lblResult.BackColor = Color.Red;
            }
        }
    }
}
