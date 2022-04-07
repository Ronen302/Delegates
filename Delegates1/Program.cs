using System;

namespace Delegates1
{
    public delegate int AddDelegate(int a, int b);
    
    class Mathematics
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            AddDelegate aD = new AddDelegate(m.Add);
            int result = aD.Invoke(4, 5);
            Console.WriteLine(result);
            Console.WriteLine(aD(8, 9));
            Console.ReadKey();
        }
    }
}
