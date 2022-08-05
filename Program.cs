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
        List<double> nums = new();
        int input = 0;

        //take n inputs
        Console.WriteLine("provide # of times to run");

        bool run = true;
        while (run == true)
        {
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                run = false;
            }
            catch
            {
                Console.WriteLine("input invalid, try again with a number");
            }
        }
        Console.WriteLine($"begin inputting numbers {input} times");
        int count = 0;
        while (count != input)
        {
            try
            {
                Console.Write(count + 1 + ":");
                count++;
                nums.Add(Convert.ToDouble(Console.ReadLine()));
            }
            catch
            {
                count--;
                Console.WriteLine($"You input something that isn't an integer, you idiot");
            }
        }

        //account for decimals in a double
        double averages = 0;

        //loop each item in list
        foreach (int num in nums)
        {
            averages += num;
        }
        Console.WriteLine($"The average of your {input} inputs, is {averages / nums.Count}");

    }
}
    
