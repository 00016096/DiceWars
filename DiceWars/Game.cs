using DiceWars.DAL;
using DiceWars.DAL.Entities;

namespace DiceWars
{
    public partial class Game : Form
    {
        public Clash Clash { get; set; }


        public Game()
        {
            InitializeComponent();
        }

        private async void Game_Load(object sender, EventArgs e)
        {
            cbxPlayer1.DataSource = await new PlayerManager().GetAllAsync();
            cbxPlayer2.DataSource = await new PlayerManager().GetAllAsync();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if (cbxPlayer1.SelectedIndex != cbxPlayer2.SelectedIndex)
            {
                Clash = new Clash();
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

                }
                else if ((num1 + num2 + num3 + num4 + num5) < (num6 + num7 + num8 + num9 + num10))
                {
                    label13.Text = "Player 2 wins!";
                }
                else
                {
                    label13.Text = "Tie!";
                }

                // var manager = new ClashManager();
                // manager.Create(Clash);

            }
            else
            {
                MessageBox.Show("Please, choose two different players");
            }

        }
    }
}
