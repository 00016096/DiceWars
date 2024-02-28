using System.Threading.Tasks.Sources;




namespace DiceWars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var player = new Player();
            player.Score = 0;
            player.LastGameDate = new DateTime(2000, 01, 01);
        }
    }
}