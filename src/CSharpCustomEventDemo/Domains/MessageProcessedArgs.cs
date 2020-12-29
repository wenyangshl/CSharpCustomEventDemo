using System;

namespace CSharpCustomEventDemo.Domains
{
    public class MessageProcessedArgs : EventArgs
    {
        public string Message { get; set; }
        public MessageProcessedArgs(string message) => Message = message;
    }
}
