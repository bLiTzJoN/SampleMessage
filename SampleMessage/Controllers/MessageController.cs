using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleMessage.Models;

namespace SampleMessage.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private IMessenger _messenger;

        public MessageController(IMessenger messenger)
        {
            _messenger = messenger;
        }

        [HttpGet]
        public Message Get()
        {
            return _messenger.GetMessage();
        }
    }
}
