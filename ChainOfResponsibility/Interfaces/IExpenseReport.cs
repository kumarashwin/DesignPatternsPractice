﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    interface IExpenseReport
    {
        Decimal Total { get;}
    }
}
