using DiceWars.DAL.Entities;

namespace DiceWars
{
    partial class AllPlayers
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
            dgv = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IsPvPEnabled = new DataGridViewTextBoxColumn();
            LastGameDate = new DataGridViewTextBoxColumn();
            scoreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            playerBindingSource1 = new BindingSource(components);
            playerBindingSource = new BindingSource(components);
            cbxSort = new ComboBox();
            btnSort = new Button();
            tbxSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoGenerateColumns = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, IsPvPEnabled, LastGameDate, scoreDataGridViewTextBoxColumn });
            dgv.DataSource = playerBindingSource1;
            dgv.Location = new Point(12, 4);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(562, 338);
            dgv.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // IsPvPEnabled
            // 
            IsPvPEnabled.DataPropertyName = "IsPvPEnabled";
            IsPvPEnabled.HeaderText = "Is PvP Enabled";
            IsPvPEnabled.MinimumWidth = 6;
            IsPvPEnabled.Name = "IsPvPEnabled";
            IsPvPEnabled.ReadOnly = true;
            IsPvPEnabled.Width = 125;
            // 
            // LastGameDate
            // 
            LastGameDate.DataPropertyName = "LastGameDate";
            LastGameDate.HeaderText = "Last Game Date";
            LastGameDate.MinimumWidth = 6;
            LastGameDate.Name = "LastGameDate";
            LastGameDate.ReadOnly = true;
            LastGameDate.Width = 125;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            scoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            scoreDataGridViewTextBoxColumn.ReadOnly = true;
            scoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // playerBindingSource1
            // 
            playerBindingSource1.DataSource = typeof(Player);
            // 
            // playerBindingSource
            // 
            playerBindingSource.DataSource = typeof(Player);
            // 
            // cbxSort
            // 
            cbxSort.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbxSort.FormattingEnabled = true;
            cbxSort.Items.AddRange(new object[] { "Name", "Champions", "Losers" });
            cbxSort.Location = new Point(12, 357);
            cbxSort.Name = "cbxSort";
            cbxSort.Size = new Size(296, 28);
            cbxSort.TabIndex = 1;
            // 
            // btnSort
            // 
            btnSort.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSort.Location = new Point(336, 357);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(101, 28);
            btnSort.TabIndex = 2;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // tbxSearch
            // 
            tbxSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbxSearch.Location = new Point(12, 401);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(296, 27);
            tbxSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSearch.Location = new Point(336, 400);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 28);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(595, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 51);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(595, 61);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(119, 49);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(595, 116);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 49);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new Point(595, 171);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(119, 50);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // AllPlayers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 482);
            Controls.Add(tbxSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(btnSort);
            Controls.Add(cbxSort);
            Controls.Add(dgv);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AllPlayers";
            Text = "AllPlayers";
            Load += AllPlayers_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private ComboBox cbxSort;
        private Button btnSort;
        private TextBox tbxSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn isPvPEnabledDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastGameDateDataGridViewTextBoxColumn;
        private BindingSource playerBindingSource;
        private BindingSource playerBindingSource1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IsPvPEnabled;
        private DataGridViewTextBoxColumn LastGameDate;
        private DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
    }
}