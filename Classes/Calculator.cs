public class Calculator : ICalculate
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Divide(double a, double b)
    {
          if (b == 0)
        {
            Console.WriteLine("Cannot divide a number by 0");
            throw new Exception("Program terminated!");
        }
        return a / b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }
}