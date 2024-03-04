namespace DiceWars.DAL.Entities;

public class Clash
{
    public int Id { get; set; }

    public Player? FirstPlayer { get; set; }
    public Player? SecondPlayer { get; set; }
    public DateTime Date { get; set; }
    public int Outcome { get; set; }
}
