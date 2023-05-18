Fraction first = new Fraction();
Fraction second = new Fraction(6);
Fraction third = new Fraction(6, 7);

Console.WriteLine("");
Console.WriteLine("Display the results as fractions:");
Console.WriteLine(first.GetFractionString());
Console.WriteLine(second.GetFractionString());
Console.WriteLine(third.GetFractionString());

Console.WriteLine("");
Console.WriteLine("Display the results as decimals:");
Console.WriteLine(first.GetDecimalValue());
Console.WriteLine(second.GetDecimalValue());
Console.WriteLine(third.GetDecimalValue());

Console.WriteLine("");
Console.WriteLine("Change something from each object using SetBottom() and/or SetTop()...");
first.SetTop(2);
second.SetBottom(6);
third.SetTop(1);
third.SetBottom(2);

Console.WriteLine("");
Console.WriteLine("Display the results as fractions:");
Console.WriteLine(first.GetFractionString());
Console.WriteLine(second.GetFractionString());
Console.WriteLine(third.GetFractionString());

Console.WriteLine("");
Console.WriteLine("Display the new results as decimals:");
Console.WriteLine(first.GetDecimalValue());
Console.WriteLine(second.GetDecimalValue());
Console.WriteLine(third.GetDecimalValue());