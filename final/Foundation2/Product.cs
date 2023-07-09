public class Product {
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int productId, double price) {
        _name = name;
        _productId = productId;
        _price = price;
    }

    public string GetName() {
        return _name;
    }
    public int GetProductId() {
        return _productId;
    }
    public void SetQuantity(int quantity) {
        _quantity = quantity;
    }
    public double GetTotalCost() {
        return _price * _quantity;
    }
}