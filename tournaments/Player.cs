public class Player {

    private string _name;
    private string _position;
    private int _jersey;

    public Player(string name, int jersey, string position) {
            _name = name;
            _jersey = jersey;
            _position = position;
        }

    public string Display() {
        return $"{_name}: {_position} {_jersey}";
    }

}