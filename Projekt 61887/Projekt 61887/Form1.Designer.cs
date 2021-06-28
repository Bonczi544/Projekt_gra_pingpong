
namespace Projekt_61887
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Location = new System.Drawing.Point(12, 401);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(91, 15);
            this.lblScore1.TabIndex = 1;
            this.lblScore1.Text = "Player 1 score: 0";
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Red;
            this.Ball.Location = new System.Drawing.Point(333, 214);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(22, 22);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 25;
            this.Timer.Tick += new System.EventHandler(this.mainTimerEvent);
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.player2.Location = new System.Drawing.Point(278, 12);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(126, 23);
            this.player2.TabIndex = 3;
            this.player2.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.player1.Location = new System.Drawing.Point(278, 436);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(126, 23);
            this.player1.TabIndex = 4;
            this.player1.TabStop = false;
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Location = new System.Drawing.Point(12, 36);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(91, 15);
            this.lblScore2.TabIndex = 5;
            this.lblScore2.Text = "Player 2 score: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sterowanie: A- lewo D- prawo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sterowanie: strzałki (lewo, prawo)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.lblScore1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ifkeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ifkeyup);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

