public class Team 
{
    private List<Player> _players = new List<Player>();
    private string _name = "";
    private int _wins = 0;
    private int _losses = 0;

    public Team(string name) {
        _name = name;
    }

    public void AddPlayer(Player p) {
        _players.Add(p);
    }

    public string ReturnName() {
        return _name;
    }

    public void DisplayRoster() {
        foreach(Player player in _players) {
            Console.WriteLine(player.Display());
        }
    }

    public void AddWin(int winCount = 1) {
        _wins += winCount;
    }

    public void AddLoss(int lossCount = 1) {
        _losses += lossCount;
    }

    public void DisplayRecord() {
        Console.WriteLine($"Wins: {_wins}, Losses: {_losses}");
    }

}