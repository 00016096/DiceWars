namespace DiceWars
{
    partial class EditingPlayers
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
            btnSave = new Button();
            tbxName = new TextBox();
            lblName = new Label();
            chbxPvPEnabled = new CheckBox();
            label1 = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(204, 120);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 52);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(153, 22);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(168, 27);
            tbxName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 29);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name: ";
            // 
            // chbxPvPEnabled
            // 
            chbxPvPEnabled.AutoSize = true;
            chbxPvPEnabled.Location = new Point(153, 71);
            chbxPvPEnabled.Name = "chbxPvPEnabled";
            chbxPvPEnabled.Size = new Size(85, 24);
            chbxPvPEnabled.TabIndex = 3;
            chbxPvPEnabled.Text = "Enabled";
            chbxPvPEnabled.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 2;
            label1.Text = "Player Vs. Player: ";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(81, 120);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(117, 52);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditingPlayers
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(344, 219);
            Controls.Add(chbxPvPEnabled);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(tbxName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "EditingPlayers";
            Text = "EditingPlayers";
            Load += EditingPlayers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox tbxName;
        private Label lblName;
        private CheckBox chbxPvPEnabled;
        private Label label1;
        private Button btnCancel;
    }
}