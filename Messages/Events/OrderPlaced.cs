﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace Messages.Events
{
    public class OrderPlaced : IEvent
    {
        public string OrderId { get; set; }
    }
}