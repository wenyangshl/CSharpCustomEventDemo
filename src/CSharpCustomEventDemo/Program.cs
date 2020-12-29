using CSharpCustomEventDemo.Services;
using System;

namespace CSharpCustomEventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var messageProcessor = new MessageProcessoer();
            var publisher = new MessagePublisher(messageProcessor);

            messageProcessor.ProcessMessage("soemhting");

            Console.ReadKey();
        }
    }
}
