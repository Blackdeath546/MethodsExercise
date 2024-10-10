namespace MathOperationsMethods
{
    
    class Program
    {
        public static int AddTwoNumbers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public static int SubtractTwoNumbers(int a, int b)
        {
            int subtract = a - b;
            return subtract;
        }
        public static int MultiplyTwoNumbers(int a, int b)
        {
            int product = a * b;
            return product;
        }
        public static double DivideTwoNumbers(double a, double b)
        {
            double divide = a / b;
            return divide;
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine($"These are four Operations between 10 and 20");
            
           double sum = AddTwoNumbers(10, 20);
           Console.WriteLine($"Sum: {sum}");
           
           double subtract = SubtractTwoNumbers(10, 20);
           Console.WriteLine($"Subtract: {subtract}");
           
           double multiply = MultiplyTwoNumbers(10, 20);
           Console.WriteLine($"Multiply: {multiply}");
           
           double divide = DivideTwoNumbers(10, 20);
           Console.WriteLine($"Divide: {divide}");
        }
    }
}