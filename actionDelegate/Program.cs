namespace Assignment8ex2
{   
    public class MathSolutions
    {
        public delegate double CustomMathDelegate(double a, double b);
        public double GetSum(double x, double y)
        {
            return x + y;
        }
        public double GetProduct(double a, double b)
        {
            return a * b;
        }
       /* public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }*/
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();
            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);
            Console.WriteLine($"Numbers: {num1} and {num2}");
            Action<double, double> smallerAction = delegate (double a, double b)
            {
                if (a < b)
                    Console.WriteLine($"Action: {a} is smaller than {b}");
                else if (b < a)
                    Console.WriteLine($"Action: {b} is smaller than {a}");
                else
                    Console.WriteLine($"Action: {b} is equal to {a}");
            };
            smallerAction(num1, num2);
            Func<double, double, double> sumFunc = answer.GetSum;
            Console.WriteLine($"Func: {num1} + {num2} = {sumFunc(num1, num2)}");

            CustomMathDelegate customProductDelegate = answer.GetProduct;
            Console.WriteLine($"Custom Delegate: {num1} * {num2} = {customProductDelegate(num1, num2)}");
        }
    }
}
