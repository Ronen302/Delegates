using System;

namespace Delegates_1
{
    public delegate int AddDelegates(int a, int b);
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
            AddDelegates aD = new AddDelegates(m.Add);
            int result = aD.Invoke(20, 15);
            Console.WriteLine(result);
            Console.WriteLine(aD(8, 9));
            Console.ReadKey();
        }
    }
}
