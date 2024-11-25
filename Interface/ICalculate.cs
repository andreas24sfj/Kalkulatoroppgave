public interface ICalculate
{
    /// <summary>
    /// this method adds two numbers, a and b together.
    /// </summary>
    /// <param name="a">the value of the number a</param>
    /// <param name="b">the value of the number b</param>
    /// <returns>a + b</returns>
    double Add(double a, double b);
    
    /// <summary>
    /// this method subtracts two numbers, a and b from eachother.
    /// </summary>
    /// <param name="a">the value of the number a</param>
    /// <param name="b">the value of the number b</param>
    /// <returns>a - b</returns>
    double Subtract(double a, double b);
    /// <summary>
    /// this method multiplies two numbers, a and b together.
    /// </summary>
    /// <param name="a">the value of the number a</param>
    /// <param name="b">the value of the number b</param>
    /// <returns>a * b</returns>
    double Multiply(double a, double b);

    /// <summary>
    /// This method divides two numbers, a with b.
    /// </summary>
    /// <param name="a">the value of the number a</param>
    /// <param name="b">the value of the number b</param>
    /// <returns>a / b</returns>
    double Divide(double a, double b);
}