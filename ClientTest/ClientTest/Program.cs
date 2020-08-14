using System;

namespace ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Client c1 = Client.GetInstance();


            c1.ConnectToServer();

            
            while (true)
            {
                
                ThreadManager.UpdateMain();
                
            }
            Console.ReadLine();

            // Console.ReadLine();
        }
    }
}
