namespace DiceWars.DAL.Entities;

public class Clash
{
    public int Id { get; set; }
    public Player Player1 { get; set; }
    public Player Player2 { get; set; }
    public DateTime Date { get; set; }
    public int Outcome { get; set; }
}
