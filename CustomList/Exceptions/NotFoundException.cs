﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList.Exceptions
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string mesage) : base(mesage) { }
    }
}
