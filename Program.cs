public class Program
{ 

     public static void Main(string[] args)
    {
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());
        double num4 = Convert.ToDouble(Console.ReadLine());

        double result = (num1 + num2 + num3 + num3 + num4) / 4;
        
        Console.WriteLine($"The result is: {result}");
    }
}
