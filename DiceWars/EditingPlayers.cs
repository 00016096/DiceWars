﻿using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceWars
{
    public partial class EditingPlayers : Form
    {
        public EditingPlayers()
        {
            InitializeComponent();
        }

        private void EditingPlayers_Load(object sender, EventArgs e)
        {
        }
        public Player Player { get; set; }
        public FormMode Mode { get; set; }
        public void CreateNewPlayer()
        {
            Mode = FormMode.CreateNew;
            Player = new Player();
            InitializeControls();
            MdiParent = GameForms.GetForm<ParentForm>();
            Show();
        }
        public void UpdatePlayer(Player player)
        {
            Mode = FormMode.Update;
            Player = player;
            InitializeControls();
            ShowPlayerInControls();
            MdiParent = GameForms.GetForm<ParentForm>();
            Show();
        }
        private void InitializeControls()
        {
        }
        private void ShowPlayerInControls()
        {
            tbxName.Text = Player.Name;
            chbxPvPEnabled.Checked = Player.IsPvPEnabled;
        }
        private void GrabUserInput()
        {
            Player.Name = tbxName.Text;
            Player.IsPvPEnabled = chbxPvPEnabled.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
