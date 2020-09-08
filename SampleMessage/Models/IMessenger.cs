using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMessage.Models
{
    public interface IMessenger
    {
        Message GetMessage();
    }
}
