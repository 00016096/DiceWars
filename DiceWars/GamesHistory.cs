using DiceWars.DAL;
using DiceWars.DAL.Managers;

namespace DiceWars;

public partial class GamesHistory : Form
{
    private PlayerManager playerManager;
    public GamesHistory()
    {
        InitializeComponent();
        playerManager = new();
    }

    private void GamesHistory_Load(object sender, EventArgs e)
    {
        MdiParent = GameForms.GetForm<ParentForm>();
        LoadData();
    }

    private async void LoadData()
    {
        dataGridView1.DataSource = (await new ClashManager().GetAllAsync())
            .Select(async x => new
            {
                GameId = x.Id,
                FirstPlayerName = (await playerManager.GetByIdAsync(x.FirstPlayer!.Id)).Name,
                SecondPlayerName = (await playerManager.GetByIdAsync(x.SecondPlayer!.Id)).Name,
                GameDate = x.Date,
                Outcome = x.Outcome == 1 ? "First Player won" : x.Outcome == 2 ? "Second Player won" : "Tie"
            }).Select(x => x.Result).ToList();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        LoadData();
    }
}
public class ClashDto
{
    public int GameId { get; set; }
    public string FirstPlayerName { get; set; }
    public string SecondPlayerName { get; set; }
    public DateTime GameDate { get; set; }
    public string Outcome { get; set; }
}
