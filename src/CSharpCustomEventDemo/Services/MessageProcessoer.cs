using CSharpCustomEventDemo.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCustomEventDemo.Services
{
    public class MessageProcessoer
    {
        public delegate void MessageProcessedHandler(object sender, MessageProcessedArgs args);

        public event MessageProcessedHandler RaiseMessageProcessed;

        public void ProcessMessage(string message)
        {
            OnRaiseMessageProcessed(new MessageProcessedArgs("Message Processed."));
        }

        protected virtual void OnRaiseMessageProcessed(MessageProcessedArgs args)
        {
            MessageProcessedHandler raiseMessageProcessed = RaiseMessageProcessed;

            if(raiseMessageProcessed != null)
            {
                args.Message += $" at {DateTime.Now}";

                raiseMessageProcessed(this, args);
            }
        }
    }
}
