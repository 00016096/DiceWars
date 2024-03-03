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
    public partial class GamesHistory : Form
    {
        public GamesHistory()
        {
            InitializeComponent();
        }

        private void GamesHistory_Load(object sender, EventArgs e)
        {
            MdiParent = GameForms.GetForm<ParentForm>();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = new ClashManager().GetAll();
        }
    }
}
