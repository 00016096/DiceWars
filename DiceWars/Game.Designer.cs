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
            label12 = new Label();
            label7 = new Label();
            label11 = new Label();
            label6 = new Label();
            label10 = new Label();
            label5 = new Label();
            label9 = new Label();
            label4 = new Label();
            label8 = new Label();
            label3 = new Label();
            cbxPlayer2 = new ComboBox();
            label1 = new Label();
            cbxPlayer1 = new ComboBox();
            label2 = new Label();
            btnRoll = new Button();
            playerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.BackColor = Color.Red;
            label12.Location = new Point(1159, 84);
            label12.Name = "label12";
            label12.Size = new Size(100, 100);
            label12.TabIndex = 17;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Highlight;
            label7.Location = new Point(493, 84);
            label7.Name = "label7";
            label7.Size = new Size(100, 100);
            label7.TabIndex = 18;
            // 
            // label11
            // 
            label11.BackColor = Color.Red;
            label11.Location = new Point(1038, 84);
            label11.Name = "label11";
            label11.Size = new Size(100, 100);
            label11.TabIndex = 19;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.Highlight;
            label6.Location = new Point(372, 84);
            label6.Name = "label6";
            label6.Size = new Size(100, 100);
            label6.TabIndex = 20;
            // 
            // label10
            // 
            label10.BackColor = Color.Red;
            label10.Location = new Point(922, 84);
            label10.Name = "label10";
            label10.Size = new Size(100, 100);
            label10.TabIndex = 13;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.Highlight;
            label5.Location = new Point(256, 84);
            label5.Name = "label5";
            label5.Size = new Size(100, 100);
            label5.TabIndex = 14;
            // 
            // label9
            // 
            label9.BackColor = Color.Red;
            label9.Location = new Point(806, 84);
            label9.Name = "label9";
            label9.Size = new Size(100, 100);
            label9.TabIndex = 21;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Highlight;
            label4.Location = new Point(140, 84);
            label4.Name = "label4";
            label4.Size = new Size(100, 100);
            label4.TabIndex = 22;
            // 
            // label8
            // 
            label8.BackColor = Color.Red;
            label8.Location = new Point(690, 84);
            label8.Name = "label8";
            label8.Size = new Size(100, 100);
            label8.TabIndex = 15;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Highlight;
            label3.Location = new Point(24, 84);
            label3.Name = "label3";
            label3.Size = new Size(100, 100);
            label3.TabIndex = 16;
            // 
            // cbxPlayer2
            // 
            cbxPlayer2.DataSource = playerBindingSource;
            cbxPlayer2.DisplayMember = "Name";
            cbxPlayer2.Font = new Font("Segoe UI", 20F);
            cbxPlayer2.FormattingEnabled = true;
            cbxPlayer2.Location = new Point(872, 12);
            cbxPlayer2.Name = "cbxPlayer2";
            cbxPlayer2.Size = new Size(324, 53);
            cbxPlayer2.TabIndex = 11;
            cbxPlayer2.ValueMember = "Id";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(690, 12);
            label1.Name = "label1";
            label1.Padding = new Padding(3);
            label1.Size = new Size(157, 53);
            label1.TabIndex = 8;
            label1.Text = "Player 2:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbxPlayer1
            // 
            cbxPlayer1.DisplayMember = "Name";
            cbxPlayer1.Font = new Font("Segoe UI", 20F);
            cbxPlayer1.FormattingEnabled = true;
            cbxPlayer1.Location = new Point(206, 12);
            cbxPlayer1.Name = "cbxPlayer1";
            cbxPlayer1.Size = new Size(324, 53);
            cbxPlayer1.TabIndex = 12;
            cbxPlayer1.ValueMember = "Id";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(24, 12);
            label2.Name = "label2";
            label2.Padding = new Padding(3);
            label2.Size = new Size(157, 53);
            label2.TabIndex = 9;
            label2.Text = "Player 1:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRoll
            // 
            btnRoll.Font = new Font("Segoe UI", 22F);
            btnRoll.Location = new Point(459, 311);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(479, 147);
            btnRoll.TabIndex = 10;
            btnRoll.Text = "Roll the Dice!";
            btnRoll.UseVisualStyleBackColor = true;
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(Player);
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 582);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(cbxPlayer2);
            Controls.Add(label1);
            Controls.Add(cbxPlayer1);
            Controls.Add(label2);
            Controls.Add(btnRoll);
            Name = "Game";
            Text = "Game";
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label12;
        private Label label7;
        private Label label11;
        private Label label6;
        private Label label10;
        private Label label5;
        private Label label9;
        private Label label4;
        private Label label8;
        private Label label3;
        private ComboBox cbxPlayer2;
        private Label label1;
        private ComboBox cbxPlayer1;
        private Label label2;
        private Button btnRoll;
        private BindingSource playerBindingSource;
    }
}