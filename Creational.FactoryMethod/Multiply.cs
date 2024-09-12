namespace FactoryPattern
{
    internal class Multiply : ICalculate
    {
        public void Calculate(int num1, int num2)
        {
            Console.WriteLine("a*b is {0}", num1 * num2);
        }
    }
}