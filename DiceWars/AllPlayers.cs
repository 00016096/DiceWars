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
    public partial class AllPlayers : Form
    {
        public AllPlayers()
        {
            InitializeComponent();
        }

        private void AllPlayers_Load(object sender, EventArgs e)
        {
            MdiParent = GameForms.GetForm<ParentForm>();
            LoadData();
        }

        private void LoadData()
        {
            dgv.DataSource = new PlayerManager().GetAll();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbxSort.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to sort by");
            else
            {
                ByAttribute selectedAttribute = ByAttribute.Name;
                if (cbxSort.SelectedIndex == 0)
                    selectedAttribute = ByAttribute.Name;
                else if (cbxSort.SelectedIndex == 1)
                    selectedAttribute = ByAttribute.ascScore;
                else if (cbxSort.SelectedIndex == 2)
                    selectedAttribute = ByAttribute.descScore;

                dgv.DataSource = new PlayerManager().Sort(selectedAttribute);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSearch.Text))
                MessageBox.Show("Provide the search term");
            else
            {
                dgv.DataSource = new PlayerManager().Search(ByAttribute.Name, tbxSearch.Text);
            }

        }
    }
}
