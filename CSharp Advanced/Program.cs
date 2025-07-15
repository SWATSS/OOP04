using CSharp_Advanced.Classes;

namespace CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:
            int result1 = Calculator.Add(10, 60);
            int result2 = Calculator.Add(10, 60, 20);
            double result3 = Calculator.Add(10.6, 8.6);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            #endregion

        }
    }
}
