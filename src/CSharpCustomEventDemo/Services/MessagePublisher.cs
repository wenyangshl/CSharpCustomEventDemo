using CSharpCustomEventDemo.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCustomEventDemo.Services
{
    public class MessagePublisher
    {
        MessageProcessoer _processor;
        public MessagePublisher(MessageProcessoer processor)
        {
            processor.RaiseMessageProcessed += HandleMessageProcessedEvent;
            _processor = processor;
        }

        public void HandleMessageProcessedEvent(object sender, MessageProcessedArgs args)
        {
            Console.WriteLine("Publish Message");
        }
    }
}
