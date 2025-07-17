using Part02.Classes;

namespace Part02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 3 - Define All Required Constructors to Produce this output:
            Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1);

            Duration D2 = new Duration(3600);
            //Console.WriteLine(D2);

            Duration D3 = new Duration(7800);
            //Console.WriteLine(D3);

            Duration D4 = new Duration(666);
            //Console.WriteLine(D4);
            #endregion

            #region 4-Implement All required Operators overloading to enable this Code:
            D3 = D1 + D2;
            Console.WriteLine(D3);
            D3 = D1 + 7800;
            Console.WriteLine(D3);
            D3 = 666 + D3;
            Console.WriteLine(D3);
            D3 = ++D1;
            D3 = --D2;
            D1 = D1 - D2;
            if (D1 > D2) ;
            if (D1 <= D2) ;
            if (D1) ;
            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj);

            #endregion
        }
    }
}
