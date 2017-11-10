/*TicTacToe.cs
 * Assignment2 
 * Revision History : Created by Archana Lohani on 5th Oct 2017
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALohaniAssignment2
{
    /// <summary>
    /// Class for TicTacToe form
    /// </summary>
    public partial class TicTacToe : Form
    {
        //Declaring variable
        Image x = Properties.Resources.rsz_x;
        Image o = Properties.Resources.rsz_o;

        bool turn = true;
        int turnCount = 0;

        const int TOTAL_COUNT = 9;
        /// <summary>
        /// TicTacToe form constructor
        /// </summary>
        public TicTacToe()
        {
            InitializeComponent();
        }
              
        /// <summary>
        /// method to reset TicTacToe Form
        /// </summary>
        private void Reset()
        {
            turnCount = 0;
            turn = true;

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;         

        }

        /// <summary>
        /// method to check winner and display message regarding winner or draw
        /// </summary>
        public void CheckWinner()
        {
            bool winnerFound = false;
            string winner = "";

            //checks horizontally for X
            if ((pictureBox1.Image == x) && (pictureBox2.Image == x) && (pictureBox3.Image == x))
            {
                winnerFound = true;
            }

            else if ((pictureBox4.Image == x) && (pictureBox5.Image == x) && (pictureBox6.Image == x))
            {
                winnerFound = true;
            }

            else if ((pictureBox7.Image == x) && (pictureBox8.Image == x) && (pictureBox9.Image == x))
            {
                winnerFound = true;
            }

            //Checks vertically for X
            else if ((pictureBox1.Image == x) && (pictureBox4.Image == x) && (pictureBox7.Image == x))
            {
                winnerFound = true;
            }

            else if ((pictureBox2.Image == x) && (pictureBox5.Image == x) && (pictureBox8.Image == x))
            {
                winnerFound = true;
            }

            else if ((pictureBox3.Image == x) && (pictureBox6.Image == x) && (pictureBox9.Image == x))
            {
                winnerFound = true;
            }

            //Checks diagonally for x
            else if ((pictureBox1.Image == x) && (pictureBox5.Image == x) && (pictureBox9.Image == x))
            {
                winnerFound = true;
            }

            else if ((pictureBox3.Image == x) && (pictureBox5.Image == x) && (pictureBox7.Image == x))
            {
                winnerFound = true;
            }

            //checks horizontally for O
            if ((pictureBox1.Image == o) && (pictureBox2.Image == o) && (pictureBox3.Image == o))
            {
                winnerFound = true;
            }

            else if ((pictureBox4.Image == o) && (pictureBox5.Image == o) && (pictureBox6.Image == o))
            {
                winnerFound = true;
            }

            else if ((pictureBox7.Image == o) && (pictureBox8.Image == o) && (pictureBox9.Image == o))
            {
                winnerFound = true;
            }

            //Checks vertically for O
            else if ((pictureBox1.Image == o) && (pictureBox4.Image == o) && (pictureBox7.Image == o))
            {
                winnerFound = true;
            }

            else if ((pictureBox2.Image == o) && (pictureBox5.Image == o) && (pictureBox8.Image == o))
            {
                winnerFound = true;
            }

            else if ((pictureBox3.Image == o) && (pictureBox6.Image == o) && (pictureBox9.Image == o))
            {
                winnerFound = true;
            }

            //Checks diagonally for O
            else if ((pictureBox1.Image == o) && (pictureBox5.Image == o) && (pictureBox9.Image == o))
            {
                winnerFound = true;
            }

            else if ((pictureBox3.Image == o) && (pictureBox5.Image == o) && (pictureBox7.Image == o))
            {
                winnerFound = true;
            }

            //if winner is found it will display the message who is winner
            if (winnerFound)
            {
                DisablePictureBox();

                if (turn)
                {
                    winner = "O";
                }
                else
                {
                    winner = "X";
                }

                MessageBox.Show($"{winner} wins");
                Reset();
            }
            //checks for draw
            else
            {
                if (turnCount == TOTAL_COUNT)
                {
                    MessageBox.Show("Draw. Try Again");
                    Reset();
                }
            }
        }                     
        
        /// <summary>
        /// method to disable picture box
        /// </summary>
        private void DisablePictureBox()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            
        }

        /// <summary>
        /// method for click event when player clicks any of the picture box
        /// </summary>
        /// <param name="sender">Sender is picture box object that initiates the function</param>
        /// <param name="e"></param>
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
           
            p.Enabled = false;

            if (turn)
            {
                p.Image = x;
            }

            else
            {
                p.Image = o;
            }  
                       
            turn = !turn;
            turnCount++;
            CheckWinner();          
            
        }
    }
}
