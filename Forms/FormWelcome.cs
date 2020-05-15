using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using Memory_Game.Forms;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class frmWelcome : Form
    {
        private Thread thread;

        public frmWelcome()
        {
            InitializeComponent();
        }

        public static string Player1 = "";

        public static string Player2 = "";

        public static bool Easy;

        public static bool Medium;

        public static bool Hard;

        public static string DifficultyLevel = "";

       
        private void btnPlay_Click(object sender, EventArgs e)
        {

            Player1 = txtBxPlayer1.Text;
            Console.WriteLine("Player 1's name is " + Player1);

            Player2 = txtBxPlayer2.Text;
            Console.WriteLine("Player 2's name is " + Player2);

            
            if (rdBtnEasy.Checked)
            {
                Easy = rdBtnEasy.Checked;
                DifficultyLevel = rdBtnEasy.Text;
                Console.WriteLine("Difficulty level is " + DifficultyLevel);
            }

            else if (rdBtnMedium.Checked)
            {
                Medium = rdBtnMedium.Checked;
                DifficultyLevel = rdBtnMedium.Text;
                Console.WriteLine("Difficulty level is " + DifficultyLevel);
            }

            else if (rdBtnHard.Checked)
            {
                Hard = rdBtnHard.Checked;
                DifficultyLevel = rdBtnHard.Text;
                Console.WriteLine("Difficulty level is " + DifficultyLevel);
            }

            if (txtBxPlayer1.Text == ""||txtBxPlayer2.Text == "")
            {
                MessageBox.Show("Please Fill In Player's Name");
            }
            else
            {
                frmDashboard frm = new frmDashboard();

                this.Close();
                thread = new Thread(openFrmDashboard);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }

        }

        private void openFrmDashboard()
        {
            Application.Run(new frmDashboard());
        }

    }    
}
