using DiceWars.DAL.Entities;

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
            components = new System.ComponentModel.Container();
            playerBindingSource = new BindingSource(components);
            playerBindingSource1 = new BindingSource(components);
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            playersToolStripMenuItem = new ToolStripMenuItem();
            allPlayersToolStripMenuItem = new ToolStripMenuItem();
            newPlayerToolStripMenuItem = new ToolStripMenuItem();
            clashToolStripMenuItem = new ToolStripMenuItem();
            allClahesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(Player);
            // 
            // playerBindingSource1
            // 
            playerBindingSource1.DataSource = typeof(Player);
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
            allPlayersToolStripMenuItem.Size = new Size(166, 26);
            allPlayersToolStripMenuItem.Text = "All players";
            allPlayersToolStripMenuItem.Click += allPlayersToolStripMenuItem_Click;
            // 
            // newPlayerToolStripMenuItem
            // 
            newPlayerToolStripMenuItem.Name = "newPlayerToolStripMenuItem";
            newPlayerToolStripMenuItem.Size = new Size(166, 26);
            newPlayerToolStripMenuItem.Text = "New Player";
            newPlayerToolStripMenuItem.Click += newPlayerToolStripMenuItem_Click;
            // 
            // clashToolStripMenuItem
            // 
            clashToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allClahesToolStripMenuItem, newGameToolStripMenuItem });
            clashToolStripMenuItem.Name = "clashToolStripMenuItem";
            clashToolStripMenuItem.Size = new Size(62, 24);
            clashToolStripMenuItem.Text = "Game";
            // 
            // allClahesToolStripMenuItem
            // 
            allClahesToolStripMenuItem.Name = "allClahesToolStripMenuItem";
            allClahesToolStripMenuItem.Size = new Size(185, 26);
            allClahesToolStripMenuItem.Text = "Games history";
            allClahesToolStripMenuItem.Click += allClahesToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, playersToolStripMenuItem, clashToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1273, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(224, 26);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 696);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "ParentForm";
            Text = "Dice Wars";
            WindowState = FormWindowState.Maximized;
            Load += ParentForm_Load;
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource playerBindingSource;
        private BindingSource playerBindingSource1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem playersToolStripMenuItem;
        private ToolStripMenuItem allPlayersToolStripMenuItem;
        private ToolStripMenuItem newPlayerToolStripMenuItem;
        private ToolStripMenuItem clashToolStripMenuItem;
        private ToolStripMenuItem allClahesToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newGameToolStripMenuItem;
    }
}