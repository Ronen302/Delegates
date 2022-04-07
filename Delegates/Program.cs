using System;

namespace Delegates
{
    public delegate void MyDelegate();

    class SomeClass
    {
        public static void Method()
        {
            Console.WriteLine("Hello World!");
        }
        public void HelloMethod(int a, int b)
        {
            Console.WriteLine("Hello");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate mD = new MyDelegate(SomeClass.Method);
            mD.Invoke();
            mD();
            Console.ReadKey();
        }
            
    }
}