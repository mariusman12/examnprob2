﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class CreditFactory // Factory Class 
    {
        public abstract Icredit GetCreditType(string type);
    }
}
