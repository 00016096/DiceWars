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
        dataGridView1.DataSource = (await new ClashManager().GetAllAsync()).Select(x => new
        {
            x.Id,
            FirstPlayerName = x.FirstPlayer!.Name,
            SecondPlayerName = x.SecondPlayer!.Name,
            x.Date,
            Outcome = x.Outcome == 1 ? "First Player won" : x.Outcome == 2 ? "Second Player won" : "Tie"
        });
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
