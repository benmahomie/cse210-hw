public class Address {
    private string _streetAddress;
    private string _city;
    private string _state;

    public Address(string streetAddress, string city, string state) {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
    }

    public string GetAddress() {
        return $"{_streetAddress}, {_city}, {_state}";
    }
}