﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemenChoice_BAL.ModelView
{
    public class MessageDtoRequest
    {
        public int CustomerId { get; set; }
        public string? Content { get; set; }
        public DateTime? SendTime { get; set; }
    }
}
