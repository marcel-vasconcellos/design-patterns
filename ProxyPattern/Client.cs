using System;

namespace ProxyPattern
{
    internal class Client
    {
        static void Main(string[] args)
        {
            /*The objective of the proxy pattern is to be a placeholder fon an original object,
              which access to has to be restricted. */
            Console.WriteLine("***Proxy Pattern Demo***\n");
            Subject proxy = new Proxy();
            proxy.DoSomeWork();
            Console.ReadKey();
        }
    }
}
