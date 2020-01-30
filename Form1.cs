using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**********************************\
*            1/30/2020             *
*                                  *
*        Andrew Terwilliger        *
*        Group 3 Lab with:         *
*          Simon Avenson           *
*           Omar Mohamud           *
*        Minneapolis College       *
*    ITEC 2505-60 C# Programming   *
*                                  *
\**********************************/

namespace PasswordTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // "Estimate" button function, checks the password text to validate the quality of the provided password.
        private void btnEstimate_Click(object sender, EventArgs e)
        {
            // Simplify the string into one variable to use instead of repeating the same function every time.
            string password = txtPassword.Text;

            
            //The following statement checks if the password length is equal to or greater than 16 characters, has a digit, uppercased characters and punctuation.
       
            if (password.Length >= 16 && password.Any(char.IsDigit) && password.Any(char.IsUpper) && password.Any(char.IsPunctuation)) {

                lblResult.Text = "Best";
                lblResult.BackColor = Color.Green;
            }
            // The following statement checks if the password length is equal to or greater than 10 characters, has a digit and uppercase letters.
            else if (password.Length >= 10 && password.Any(char.IsDigit) && password.Any(char.IsUpper)) {
                lblResult.Text = "Good";
                lblResult.BackColor = Color.LightBlue;
            }
            // The following statement checks if the password length is greater than or equal to 10 characters, has a digit OR uppercase letters.
            else if (password.Length >= 10 && (password.Any(char.IsDigit) || password.Any(char.IsUpper))) {
                lblResult.Text = "Fair";
                lblResult.BackColor = Color.LightYellow;
            } 
            // Elsewise, the password is basic and not a viable solution.
            else {
                lblResult.Text = "Bad";
                lblResult.BackColor = Color.Red;
            }
        }
    }
}
