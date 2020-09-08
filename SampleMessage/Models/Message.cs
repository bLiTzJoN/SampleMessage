using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMessage.Models
{
    public class Message
    {
        public Message(string content)
        {
            Content = content;
        }
        public string Content { get; private set; }
    }
}
