﻿using DA_mau_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_mau_Utilities.CustomerRequest
{
    public class CustomerUpdateRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
    }
}
