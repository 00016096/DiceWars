using DiceWars.DAL;
using DiceWars.DAL.Entities;

namespace DiceWars;

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

    public async void LoadData()
    {
        dgv.DataSource = await new PlayerManager().GetAllAsync();
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
                selectedAttribute = ByAttribute.Champions;
            else if (cbxSort.SelectedIndex == 2)
                selectedAttribute = ByAttribute.Losers;

            dgv.DataSource = new PlayerManager().SortAsync(selectedAttribute);
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(tbxSearch.Text))
        {
            MessageBox.Show("Provide the search term");
        }
        else
        {
            dgv.DataSource = new PlayerManager().SearchAsync(ByAttribute.Name, tbxSearch.Text);
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        new EditingPlayers().CreateNewPlayer();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (dgv.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a course");
        }
        else
        {
            var c = (Player)dgv.SelectedRows[0].DataBoundItem;
            new EditingPlayers().UpdatePlayer(c);
        }
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgv.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a course");
        }
        else
        {
            var c = (Player)dgv.SelectedRows[0].DataBoundItem;
            await new PlayerManager().DeleteAsync(c.Id);
            LoadData();
        }
    }

    private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }
}