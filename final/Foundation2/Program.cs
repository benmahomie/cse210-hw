// Create customer "Joe Smith"
Address joeSmithAddress = new Address("2050 Walker Ln.", "Jamestown", "Virginia", "USA"); // Create an address
Customer joeSmith = new Customer("Joe Smith", joeSmithAddress); // Create a customer
// Create customer "Stanley"
Address stanleyAddress = new Address("400 Office Blvd.", "Essex", "Wales", "United Kindom"); // Create an address
Customer stanley = new Customer("Stanley", stanleyAddress); // Create a customer

// Create 3 products:
// 1. Create boxProduct product
Product boxProduct = new Product("Large Boxes", 0008321, 3.50); 
boxProduct.SetQuantity(500); // Set boxProduct quantity
// 2. Create lampProduct product
Product lampProduct = new Product("Floor Lamp", 0008320, 14.99); 
lampProduct.SetQuantity(15); // Set lampProduct quantity
// 3. Create reassuranceBucketProduct product
Product reassuranceBucketProduct = new Product("Reassurance Bucket", 0000001, 999.99); 
reassuranceBucketProduct.SetQuantity(1); // Set reassuranceBucketProduct quantity

// Create a customer order for "Joe Smith"
Order joeSmithOrder = new Order(joeSmith); 
joeSmithOrder.AddProduct(boxProduct); // Add boxProduct to customer order
joeSmithOrder.AddProduct(lampProduct); // Add lampProduct to customer order
// Create a customer order for "Stanley"
Order stanleyOrder = new Order(stanley); 
stanleyOrder.AddProduct(reassuranceBucketProduct);
stanleyOrder.AddProduct(lampProduct);

// Print order information for "Joe Smith"
joeSmithOrder.PrintPackingLabel(); // Print the packing label for the package
Console.WriteLine();
joeSmithOrder.PrintShippingLabel(); // Print the shipping label for the package
Console.WriteLine();
Console.WriteLine($"Total: ${joeSmithOrder.GetTotalCost()}"); // Print the total cost of the customer order
// Print order information for "Stanley"
stanleyOrder.PrintPackingLabel(); // Print the packing label for the package
Console.WriteLine();
stanleyOrder.PrintShippingLabel(); // Print the shipping label for the package
Console.WriteLine($"Total: ${stanleyOrder.GetTotalCost()}"); // Print the total cost of the customer order