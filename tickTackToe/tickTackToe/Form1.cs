using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tickTackToe
{
    public partial class Form1 : Form
    {
        bool player1 = false;
        bool player2 = false;
        String PrevbtnTxt = "";
        bool btn_Enb = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void btn_Enabled()
        {
            if (btn_Enb == true)
            {
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn5.Enabled = true;
                btn6.Enabled = true;
                btn7.Enabled = true;
                btn8.Enabled = true;
                btn9.Enabled = true;
            }
           else
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rbPlayer1.Checked || rbPlayer2.Checked)
            {
                btn_Enb = true;
                btn_Enabled();
            }
            btnStart.Enabled = false;
            rbPlayer1.Enabled = false;
            rbPlayer2.Enabled = false;
            if (rbPlayer1.Checked)
            {
                player1 = true;
            }
            else
            {
                player2 = true;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            if (player1 == true)
            {
                if (btn.Text == "" && PrevbtnTxt == "")
                {
                    btn.Text = "O";
                    PrevbtnTxt = btn.Text;
                }
                else if (PrevbtnTxt == "O" && btn.Text == "")
                {
                    btn.Text = "X";
                    endGame();
                    btn_Enabled();
                    PrevbtnTxt = btn.Text;
                }
                else if (PrevbtnTxt == "X" && btn.Text == "")
                {
                    btn.Text = "O";
                    endGame();
                    btn_Enabled();
                    PrevbtnTxt = btn.Text;
 
                }


            }
            else
            {
                if (btn.Text == "" && PrevbtnTxt == "")
                {
                    btn.Text = "X";
                    PrevbtnTxt = btn.Text;
                }
                else if (PrevbtnTxt == "X" && btn.Text == "")
                {
                    
                    btn.Text = "O";
                    endGame();
                    btn_Enabled();
                    PrevbtnTxt = btn.Text;
                }
                else if (PrevbtnTxt == "O" && btn.Text == "")
                {
                    btn.Text = "X";
                    endGame();
                    btn_Enabled();
                    PrevbtnTxt = btn.Text;
                }
            }

        }

        bool endGame()
        {
            bool x = false;
            if (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn1.Text == btn3.Text)
            {
                if (btn1.Text == "O")
                {
                    MessageBox.Show("Congratulations! Player 1 Wins");
                    btn_Enb = false;
                }
                else if(btn1.Text=="X")
                {
                    MessageBox.Show("Congratulations! Player 2 Wins");
                    btn_Enb = false;
                }
                x = true;
            }
            if (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn4.Text == btn6.Text)
            {
                if (btn4.Text == "O")
                {
                    MessageBox.Show("Congratulations! Player 1 Wins");
                    btn_Enb = false;
                }
                else if (btn4.Text == "X")
                {
                    MessageBox.Show("Congratulations! Player 2 Wins");
                    btn_Enb = false;
                }
                x = true;
            }
             if (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn7.Text == btn9.Text)
            {
                if (btn7.Text == "O")
                {
                    MessageBox.Show("Congratulations! Player 1 Wins");
                    btn_Enb = false;
                }
                else if(btn7.Text == "X")
                {
                    MessageBox.Show("Congratulations! Player 2 Wins");
                    btn_Enb = false;
                }
                x = true;
            }
             if (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn1.Text == btn7.Text)
            {
                if (btn1.Text == "O")
                {
                    MessageBox.Show("Congratulations! Player 1 Wins");
                    btn_Enb = false;
                }
                else if (btn1.Text == "X")
                {
                    MessageBox.Show("Congratulations! Player 2 Wins");
                    btn_Enb = false;
                }
                x = true;
            }
             if (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn2.Text == btn8.Text)
            {
                if (btn2.Text == "O")
                {
                    MessageBox.Show("Congratulations! Player 1 Wins");
                    btn_Enb = false;
                }
                else if (btn2.Text == "X")
                {
                    MessageBox.Show("Congratulations! Player 2 Wins");
                    btn_Enb = false;
                }
                x = true;
            }
             if (btn3.Text == btn6.Text && btn3.Text == btn9.Text  && btn3.Text == btn9.Text)
            {
                if (btn3.Text == "O")
                {
                    MessageBox.Show("Congratulations! Player 1 Wins");
                    btn_Enb = false;

                }
                else if (btn3.Text == "X")
                {
                    MessageBox.Show("Congratulations! Player 2 Wins");
                    btn_Enb = false;
                }
                x = true;
            }
             if (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn1.Text == btn9.Text)
            {
                if (btn1.Text == "O")
                {
                    MessageBox.Show("Congratulations! Player 1 Wins");
                    btn_Enb = false;

                }
                else if (btn1.Text == "X")
                {
                    MessageBox.Show("Congratulations! Player 2 Wins");
                    btn_Enb = false;
                }
                x = true;
            }
              if (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn3.Text == btn7.Text)
            {
                if (btn3.Text == "O")
                {
                    MessageBox.Show("Congratulations! Player 1 Wins");
                    btn_Enb = false;

                }
                else if (btn3.Text == "X")
                {
                    MessageBox.Show("Congratulations! Player 2 Wins");
                    btn_Enb = false;
                }
                x = true;
            }
              if(btn1.Text !="" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "" && x == false)
            {
                MessageBox.Show("Match is draw! Play Again");
                btn_Enb = false;
            }
            return x;
        }
 
    }
}
