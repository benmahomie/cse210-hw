using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        
        int number;

        // ask for entries until 0 is received
        do {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0) {
                numbers.Add(number);
            }
        } while (number != 0);

        // compute sum
        int sum = 0;
        foreach (int entry in numbers) {
            sum += entry;
        }
        Console.WriteLine($"The sum is: {sum}");

        // compute average
        float sumFloat = sum;
        float countFloat = numbers.Count;
        float average = sum/countFloat;
        Console.WriteLine($"The average is: {average}");

        // compute largest number
        int largest = 0;
        foreach (int entry in numbers) {
            if (largest < entry) {
                largest = entry;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");  
              
    }
}