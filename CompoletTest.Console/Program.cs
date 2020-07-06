namespace CompoletTest.Console
{
    using System;
    using CompoletTest.Library;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CIP通信テスト: Hit any key!!");
            Console.ReadKey();
            var client = new Class1();
            Console.WriteLine(client.SharedMemTest().ToString());
            Console.ReadKey();
        }
    }
}
