using DiceWars.DAL;
using DiceWars.DAL.Entities;
using DiceWars.DAL.Managers;

namespace DiceWars
{
    public partial class Game : Form
    {
        private Clash _clash;
        private ClashManager _clashManager;
        private PlayerManager _playerManager;

        public Game()
        {
            InitializeComponent();
            _clash = new();
            _clashManager = new();
            _playerManager = new();
        }

        private async void Game_Load(object sender, EventArgs e)
        {
            cbxPlayer1.DataSource = await new PlayerManager().GetAllAsync();
            cbxPlayer2.DataSource = await new PlayerManager().GetAllAsync();
        }

        private async void btnRoll_Click(object sender, EventArgs e)
        {
            if (cbxPlayer1.SelectedIndex != cbxPlayer2.SelectedIndex)
            {
                Random random = new Random();
                label3.Text = random.Next(1, 7).ToString();
                label4.Text = random.Next(1, 7).ToString();
                label5.Text = random.Next(1, 7).ToString();
                label6.Text = random.Next(1, 7).ToString();
                label7.Text = random.Next(1, 7).ToString();
                label8.Text = random.Next(1, 7).ToString();
                label9.Text = random.Next(1, 7).ToString();
                label10.Text = random.Next(1, 7).ToString();
                label11.Text = random.Next(1, 7).ToString();
                label12.Text = random.Next(1, 7).ToString();


                var num1 = Convert.ToInt16(label3.Text);
                var num2 = Convert.ToInt16(label4.Text);
                var num3 = Convert.ToInt16(label5.Text);
                var num4 = Convert.ToInt16(label6.Text);
                var num5 = Convert.ToInt16(label7.Text);
                var num6 = Convert.ToInt16(label8.Text);
                var num7 = Convert.ToInt16(label9.Text);
                var num8 = Convert.ToInt16(label10.Text);
                var num9 = Convert.ToInt16(label11.Text);
                var num10 = Convert.ToInt16(label12.Text);

                if ((num1 + num2 + num3 + num4 + num5) > (num6 + num7 + num8 + num9 + num10))
                {
                    label13.Text = "Player 1 wins!";
                    _clash.Date = DateTime.Now;
                    _clash.Outcome = 1;
                    _clash.FirstPlayer = (Player)cbxPlayer1.SelectedItem!;
                    _clash.SecondPlayer = (Player)cbxPlayer2.SelectedItem!;
                }
                else if ((num1 + num2 + num3 + num4 + num5) < (num6 + num7 + num8 + num9 + num10))
                {
                    label13.Text = "Player 2 wins!";
                    _clash.Date = DateTime.Now;
                    _clash.Outcome = 2;
                    _clash.FirstPlayer = (Player)cbxPlayer1.SelectedItem!;
                    _clash.SecondPlayer = (Player)cbxPlayer2.SelectedItem!;
                }
                else
                {
                    label13.Text = "Tie!";
                    _clash.Date = DateTime.Now;
                    _clash.Outcome = 0;
                    _clash.FirstPlayer = (Player)cbxPlayer1.SelectedItem!;
                    _clash.SecondPlayer = (Player)cbxPlayer2.SelectedItem!;
                }
                await _clashManager.CreateAsync(_clash);
            }
            else
            {
                MessageBox.Show("Please, choose two different players");
            }

        }
    }
}
