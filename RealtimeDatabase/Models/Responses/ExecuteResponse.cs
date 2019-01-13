﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RealtimeDatabase.Models.Responses
{
    class ExecuteResponse : ResponseBase
    {
        public object Result { get; set; }

        public ExecuteResponseType Type { get; set; }

        public enum ExecuteResponseType
        {
            End, Notify
        }
    }
}