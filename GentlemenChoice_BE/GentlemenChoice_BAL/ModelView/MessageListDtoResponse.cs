﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemenChoice_BAL.ModelView
{
    public class MessageListDtoResponse
    {
        public string? CustomerName { get; set; }
        public MessageDtoResponse? response { get; set; }
    }
}
