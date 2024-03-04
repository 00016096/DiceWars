using DiceWars.DAL.Entities;

namespace DiceWars
{
    partial class GamesHistory
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
            playerBindingSource1 = new BindingSource(components);
            playerBindingSource = new BindingSource(components);
            btnRefresh = new Button();
            clashBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            GameId = new DataGridViewTextBoxColumn();
            FirstPlayerName = new DataGridViewTextBoxColumn();
            SecondPlayerName = new DataGridViewTextBoxColumn();
            outcomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GameDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clashBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // playerBindingSource1
            // 
            playerBindingSource1.DataSource = typeof(Player);
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(Player);
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new Point(723, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(119, 50);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // clashBindingSource
            // 
            clashBindingSource.DataSource = typeof(Clash);
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { GameId, FirstPlayerName, SecondPlayerName, outcomeDataGridViewTextBoxColumn, GameDate });
            dataGridView1.DataSource = clashBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(687, 435);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // GameId
            // 
            GameId.DataPropertyName = "GameId";
            GameId.HeaderText = "GameId";
            GameId.MinimumWidth = 6;
            GameId.Name = "GameId";
            GameId.Width = 125;
            // 
            // FirstPlayerName
            // 
            FirstPlayerName.DataPropertyName = "FirstPlayerName";
            FirstPlayerName.HeaderText = "First Player Name";
            FirstPlayerName.MinimumWidth = 6;
            FirstPlayerName.Name = "FirstPlayerName";
            FirstPlayerName.Width = 125;
            // 
            // SecondPlayerName
            // 
            SecondPlayerName.DataPropertyName = "SecondPlayerName";
            SecondPlayerName.HeaderText = "Second Player Name";
            SecondPlayerName.MinimumWidth = 6;
            SecondPlayerName.Name = "SecondPlayerName";
            SecondPlayerName.Width = 125;
            // 
            // outcomeDataGridViewTextBoxColumn
            // 
            outcomeDataGridViewTextBoxColumn.DataPropertyName = "Outcome";
            outcomeDataGridViewTextBoxColumn.HeaderText = "Outcome";
            outcomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            outcomeDataGridViewTextBoxColumn.Name = "outcomeDataGridViewTextBoxColumn";
            outcomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // GameDate
            // 
            GameDate.DataPropertyName = "GameDate";
            GameDate.HeaderText = "GameDate";
            GameDate.MinimumWidth = 6;
            GameDate.Name = "GameDate";
            GameDate.Width = 125;
            // 
            // GamesHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 480);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Name = "GamesHistory";
            Text = "GamesHistory";
            Load += GamesHistory_Load;
            ((System.ComponentModel.ISupportInitialize)playerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clashBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource playerBindingSource1;
        private BindingSource playerBindingSource;
        private Button btnRefresh;
        private BindingSource clashBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn player1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn player2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn GameId;
        private DataGridViewTextBoxColumn FirstPlayerName;
        private DataGridViewTextBoxColumn SecondPlayerName;
        private DataGridViewTextBoxColumn outcomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn GameDate;
    }
}