namespace DiceWars
{
    partial class ParentForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            playersToolStripMenuItem = new ToolStripMenuItem();
            allPlayersToolStripMenuItem = new ToolStripMenuItem();
            newPlayerToolStripMenuItem = new ToolStripMenuItem();
            clashToolStripMenuItem = new ToolStripMenuItem();
            allClahesToolStripMenuItem = new ToolStripMenuItem();
            newClashNewGameToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, playersToolStripMenuItem, clashToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // playersToolStripMenuItem
            // 
            playersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allPlayersToolStripMenuItem, newPlayerToolStripMenuItem });
            playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            playersToolStripMenuItem.Size = new Size(69, 24);
            playersToolStripMenuItem.Text = "Players";
            // 
            // allPlayersToolStripMenuItem
            // 
            allPlayersToolStripMenuItem.Name = "allPlayersToolStripMenuItem";
            allPlayersToolStripMenuItem.Size = new Size(224, 26);
            allPlayersToolStripMenuItem.Text = "All players";
            allPlayersToolStripMenuItem.Click += allPlayersToolStripMenuItem_Click;
            // 
            // newPlayerToolStripMenuItem
            // 
            newPlayerToolStripMenuItem.Name = "newPlayerToolStripMenuItem";
            newPlayerToolStripMenuItem.Size = new Size(224, 26);
            newPlayerToolStripMenuItem.Text = "New Player";
            newPlayerToolStripMenuItem.Click += newPlayerToolStripMenuItem_Click;
            // 
            // clashToolStripMenuItem
            // 
            clashToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allClahesToolStripMenuItem, newClashNewGameToolStripMenuItem });
            clashToolStripMenuItem.Name = "clashToolStripMenuItem";
            clashToolStripMenuItem.Size = new Size(62, 24);
            clashToolStripMenuItem.Text = "Game";
            // 
            // allClahesToolStripMenuItem
            // 
            allClahesToolStripMenuItem.Name = "allClahesToolStripMenuItem";
            allClahesToolStripMenuItem.Size = new Size(248, 26);
            allClahesToolStripMenuItem.Text = "Games history";
            allClahesToolStripMenuItem.Click += allClahesToolStripMenuItem_Click;
            // 
            // newClashNewGameToolStripMenuItem
            // 
            newClashNewGameToolStripMenuItem.Name = "newClashNewGameToolStripMenuItem";
            newClashNewGameToolStripMenuItem.Size = new Size(248, 26);
            newClashNewGameToolStripMenuItem.Text = "New Clash (New Game)";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "ParentForm";
            Text = "Dice Wars";
            WindowState = FormWindowState.Maximized;
            Load += ParentForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem playersToolStripMenuItem;
        private ToolStripMenuItem clashToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem allPlayersToolStripMenuItem;
        private ToolStripMenuItem newPlayerToolStripMenuItem;
        private ToolStripMenuItem allClahesToolStripMenuItem;
        private ToolStripMenuItem newClashNewGameToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}