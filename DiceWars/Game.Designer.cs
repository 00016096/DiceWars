using DiceWars.DAL.Entities;

namespace DiceWars
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label3 = new Label();
            cbxPlayer2 = new ComboBox();
            playerBindingSource = new BindingSource(components);
            label1 = new Label();
            cbxPlayer1 = new ComboBox();
            label2 = new Label();
            btnRoll = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Highlight;
            label3.Font = new Font("Segoe UI", 30F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 63);
            label3.Name = "label3";
            label3.Size = new Size(88, 75);
            label3.TabIndex = 16;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxPlayer2
            // 
            cbxPlayer2.DataSource = playerBindingSource;
            cbxPlayer2.DisplayMember = "Name";
            cbxPlayer2.Font = new Font("Segoe UI", 20F);
            cbxPlayer2.FormattingEnabled = true;
            cbxPlayer2.Location = new Point(763, 9);
            cbxPlayer2.Margin = new Padding(3, 2, 3, 2);
            cbxPlayer2.Name = "cbxPlayer2";
            cbxPlayer2.Size = new Size(284, 45);
            cbxPlayer2.TabIndex = 11;
            cbxPlayer2.ValueMember = "Id";
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(Player);
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(604, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(3, 2, 3, 2);
            label1.Size = new Size(137, 40);
            label1.TabIndex = 8;
            label1.Text = "Player 2:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxPlayer1
            // 
            cbxPlayer1.DisplayMember = "Name";
            cbxPlayer1.Font = new Font("Segoe UI", 20F);
            cbxPlayer1.FormattingEnabled = true;
            cbxPlayer1.Location = new Point(180, 9);
            cbxPlayer1.Margin = new Padding(3, 2, 3, 2);
            cbxPlayer1.Name = "cbxPlayer1";
            cbxPlayer1.Size = new Size(284, 45);
            cbxPlayer1.TabIndex = 12;
            cbxPlayer1.ValueMember = "Id";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(21, 9);
            label2.Name = "label2";
            label2.Padding = new Padding(3, 2, 3, 2);
            label2.Size = new Size(137, 40);
            label2.TabIndex = 9;
            label2.Text = "Player 1:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRoll
            // 
            btnRoll.Font = new Font("Segoe UI", 22F);
            btnRoll.Location = new Point(402, 233);
            btnRoll.Margin = new Padding(3, 2, 3, 2);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(419, 110);
            btnRoll.TabIndex = 10;
            btnRoll.Text = "Roll the Dice!";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Highlight;
            label4.Font = new Font("Segoe UI", 30F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(124, 63);
            label4.Name = "label4";
            label4.Size = new Size(88, 75);
            label4.TabIndex = 16;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Highlight;
            label5.Font = new Font("Segoe UI", 30F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(224, 63);
            label5.Name = "label5";
            label5.Size = new Size(88, 75);
            label5.TabIndex = 16;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Highlight;
            label6.Font = new Font("Segoe UI", 30F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(327, 63);
            label6.Name = "label6";
            label6.Size = new Size(88, 75);
            label6.TabIndex = 16;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Highlight;
            label7.Font = new Font("Segoe UI", 30F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(430, 63);
            label7.Name = "label7";
            label7.Size = new Size(88, 75);
            label7.TabIndex = 16;
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.Red;
            label8.Font = new Font("Segoe UI", 30F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(627, 63);
            label8.Name = "label8";
            label8.Size = new Size(88, 75);
            label8.TabIndex = 16;
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.Red;
            label9.Font = new Font("Segoe UI", 30F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(730, 63);
            label9.Name = "label9";
            label9.Size = new Size(88, 75);
            label9.TabIndex = 16;
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = Color.Red;
            label10.Font = new Font("Segoe UI", 30F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(830, 63);
            label10.Name = "label10";
            label10.Size = new Size(88, 75);
            label10.TabIndex = 16;
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.Red;
            label11.Font = new Font("Segoe UI", 30F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(933, 63);
            label11.Name = "label11";
            label11.Size = new Size(88, 75);
            label11.TabIndex = 16;
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.BackColor = Color.Red;
            label12.Font = new Font("Segoe UI", 30F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1036, 63);
            label12.Name = "label12";
            label12.Size = new Size(88, 75);
            label12.TabIndex = 16;
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI", 22F);
            label13.ForeColor = Color.ForestGreen;
            label13.Location = new Point(461, 365);
            label13.Name = "label13";
            label13.Size = new Size(317, 60);
            label13.TabIndex = 17;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 452);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbxPlayer2);
            Controls.Add(label1);
            Controls.Add(cbxPlayer1);
            Controls.Add(label2);
            Controls.Add(btnRoll);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Game";
            Text = "Game";
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private ComboBox cbxPlayer2;
        private Label label1;
        private ComboBox cbxPlayer1;
        private Label label2;
        private Button btnRoll;
        private BindingSource playerBindingSource;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}