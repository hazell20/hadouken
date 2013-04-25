﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hadouken.Common.Messaging;

namespace Hadouken.Configuration
{
    public class KeyValueChangedMessage : Message   
    {
        public string Key { get; set; }
        public object OldValue { get; set; }
        public object NewValue { get; set; }
    }
}
