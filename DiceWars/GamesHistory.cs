using DiceWars.DAL.Managers;

namespace DiceWars;

public partial class GamesHistory : Form
{
    public GamesHistory()
    {
        InitializeComponent();
    }

    private async void GamesHistory_Load(object sender, EventArgs e)
    {
        MdiParent = GameForms.GetForm<ParentForm>();
        await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        dataGridView1.DataSource = await new ClashManager().GetAllAsync();
    }
}
