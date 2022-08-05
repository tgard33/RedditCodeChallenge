public class Program
{ 

     public static void Main(string[] args)
    {
        //Original Code
        //double num1 = Convert.ToDouble(Console.ReadLine());
        //double num2 = Convert.ToDouble(Console.ReadLine());
        //double num3 = Convert.ToDouble(Console.ReadLine());
        //double num4 = Convert.ToDouble(Console.ReadLine());

        //double result = num1 + num2 + num3 + num3 + num4 / 4;

        //Console.WriteLine($"The result is: {result}");
        //Console.ReadKey();



        ////Fixed Code and solution
        //double num1 = Convert.ToDouble(Console.ReadLine());
        //double num2 = Convert.ToDouble(Console.ReadLine());
        //double num3 = Convert.ToDouble(Console.ReadLine());
        //double num4 = Convert.ToDouble(Console.ReadLine());

        //double result = (num1 + num2 + num3 + num4) / 4;
        
        //Console.WriteLine($"The result is: {result}");
        //Console.ReadKey();


        //Better Solution
        List<int> nums = new List<int> {1, 2, 3, 4, 5};
        //take user input and convert to int
        nums.Add(Convert.ToInt32(Console.ReadLine()));
        double averages = 0;
        foreach (int num in nums)
        {
            averages += num;
        }
        Console.WriteLine(averages / nums.Count);
    }
}
