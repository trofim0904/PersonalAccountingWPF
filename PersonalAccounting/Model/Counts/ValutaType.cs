﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Model.Counts
{
    public class ValutaType : ParameterType
    {
        public ValutaType(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
