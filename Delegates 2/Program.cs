using System;

namespace Delegates_2
{
    public delegate void MyDelegates();
    class Program
    {
        public static void Methood1()
        {
            Console.WriteLine("Methood1");
        }
        public static void Methood2()
        {
            Console.WriteLine("Methood2");
        }
        public static void Methood3()
        {
            Console.WriteLine("Methood3");
        }
        static void Main(string[] args)
        {
            MyDelegates mD = null;
            MyDelegates mD1 = new MyDelegates(Methood1);
            MyDelegates mD2 = new MyDelegates(Methood2);
            MyDelegates mD3 = new MyDelegates(Methood3);
            mD = mD1 + mD2 + mD3;
            mD();
            Console.WriteLine("Введите число от 1 до 7");
            int res = int.Parse(Console.ReadLine());
            switch (res)
            {
                case 1;
                    break;
                case 2;
                    break;
                case 3;
                    break;
                case 4;
                    break;
                case 5;
                    break;
                case 6;
                    break;
                case 7;
                    break;               
                    default;
                    Console.WriteLine("число должно быть от 1 до 7");
                    break;
            }
            Console.ReadKey();
        }
    }
}
