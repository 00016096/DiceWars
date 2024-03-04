using DiceWars.DAL;
using DiceWars.DAL.Entities;

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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new PlayerManager();
                if (Mode == FormMode.CreateNew)
                    await manager.CreateAsync(Player);
                else
                    await manager.UpdateAsync(Player);
                GameForms.GetForm<AllPlayers>().LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

