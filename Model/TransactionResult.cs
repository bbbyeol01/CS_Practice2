﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Kiosk.Model
{
    public class TransactionResult
    {
        public bool IsSuccess { get; set; }
        public int ApprovedAmount { get; set; }
        public string ErrorMessage { get; set; }
    }

}
