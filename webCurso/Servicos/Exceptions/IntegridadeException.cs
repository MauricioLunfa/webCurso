﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webCurso.Servicos.Exceptions
{
    public class IntegridadeException :ApplicationException
    {

        public IntegridadeException(string message) : base(message)
        {

        }
    }
}
