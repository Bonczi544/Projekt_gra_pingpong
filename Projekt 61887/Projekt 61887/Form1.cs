using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_61887
{
    public partial class Form1 : Form
    {
        bool moveLeft;
        bool moveRight;
        bool move2Left;
        bool move2Right;
        bool isGameOver;


        int score1;
        int score2;
        int ballx;
        int bally;
        int playerSpeed;

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            setupGame();
        }

        private void setupGame()
        {
            score1 = 0;
            score2 = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 13;
            lblScore1.Text = "Player 1 Score: " + score1;
            lblScore2.Text = "Player 2 Score: " + score2;

                Timer.Start();
        }

        private void gameOver(string message)
        {
            isGameOver = true;
            Timer.Stop();

            if(score1 >9)
            {
                lblScore1.Text = "Player 1 Score:" + score1 + ". You Win! " + message;
            }
            if (score2 > 9)
            {
                lblScore2.Text = "Player 2 Score:" + score2 + ". You Win! " + message;
            }
        }




        private void mainTimerEvent(object sender, EventArgs e)
        {
            //poruszanie graczem 1
            if(moveLeft == true && player1.Left>0)
            {
                player1.Left -= playerSpeed;
            }
            if(moveRight == true && player1.Left+player1.Width < 700)
            {
                player1.Left += playerSpeed;
            }


            //poruszanie graczem 2
            if (move2Left == true && player2.Left > 0)
            {
                player2.Left -= playerSpeed;
            }
            if (move2Right == true && player2.Left+player2.Width < 700)
            {
               player2.Left += playerSpeed;
            }
           
            //ruch piłki
            Ball.Left += ballx;
            Ball.Top += bally;

            //odbicie piłki od bocznych ścian
            if(Ball.Left <0 || Ball.Left +Ball.Width >700)
            {
                ballx = -ballx;
            }
            
            //odbicie piłki od gracza 1 oraz lekka zmiana jej ruchu 
            if(Ball.Bounds.IntersectsWith(player1.Bounds))
            {
                bally = rnd.Next(7, 11) * -1;

                if(ballx <0)
                {
                    ballx = rnd.Next(7, 11) * -1;
                }
                else
                {
                    ballx = rnd.Next(7, 11);
                }
            }
            //odbicie piłki od gracza 2 oraz lekka zmiana jej ruchu 
            if (Ball.Bounds.IntersectsWith(player2.Bounds))
            {
                bally = rnd.Next(7, 11);

                if (ballx < 0)
                {
                    ballx = rnd.Next(7, 11);
                }
                else
                {
                    ballx = rnd.Next(7, 11) * -1;
                }
            }
            // sprawdzanie, czy jeden z graczy uzyskał wymagany wynik 10pkt
            if(score1 >9 || score2 >9)
            {
                gameOver("Press Enter to play again");
            }



            if(Ball.Top > 500)
            {
                score2++;
                Ball.Left = 333;
                Ball.Top = 214;
                lblScore2.Text = "Player 2 Score: " + score2;

            }
            if (Ball.Top < 0)
            {
                score1++;
                Ball.Left = 333;
                Ball.Top = 214;
                lblScore1.Text = "Player 1 Score: " + score1;
            }




        }

        private void ifkeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }

            if (e.KeyCode == Keys.A)
            {
                move2Left = true;
            }
            if (e.KeyCode == Keys.D)
            {
                move2Right = true;
            }



        }

        private void ifkeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }

            if (e.KeyCode == Keys.A)
            {
                move2Left = false;
            }
            if (e.KeyCode == Keys.D)
            {
                move2Right = false;
            }
            if(e.KeyCode == Keys.Enter && isGameOver ==true)
            {
                setupGame();
            }



        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
