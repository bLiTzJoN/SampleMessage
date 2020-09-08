using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMessage.Models
{
    public class MockMessenger : IMessenger
    {
        public Message GetMessage()
        {
            return new Message("Hello World");
        }
    }
}
