public class Order {
    private List<Product> _productList = new List<Product>();
    private Customer _customer;

    public Order(Customer customer) {
        _customer = customer;
    }

    public void AddProduct(Product product) {
        _productList.Add(product);
    }

    public void PrintPackingLabel() {
        Console.WriteLine("[PACKING LABEL]");
        foreach (Product product in _productList) {
            Console.WriteLine($"{product.GetName()} : {product.GetProductId()}");
        }
    }

    public void PrintShippingLabel() {
        Console.WriteLine("[SHIPPING LABEL]\n");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress());
    }

    public double GetTotalCost() {
        double totalCost = 0.00;
        foreach (Product product in _productList) {
            totalCost += product.GetTotalCost();
        }

        int shippingCost = 5; // Default shipping price is for USA ($5)
        if (_customer.InUSA() == false) {
            shippingCost = 35;
        }
        totalCost += shippingCost;

        return totalCost;
    }
}