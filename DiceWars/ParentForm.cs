using DiceWars.DAL;
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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            var manager = new PlayerManager();
            MessageBox.Show(manager.GetAll().Count.ToString());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void allClahesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void allPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AllPlayersForm = new AllPlayers();
            AllPlayersForm.MdiParent = this;
            AllPlayersForm.Show();
        }
    }
}
