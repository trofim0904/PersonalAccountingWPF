﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalAccounting.Services
{
    public class WeatherModel
    {
        public Main Main { get; set; }
    }
    public class Main
    {
        public float Feels_like { get; set; }
        public float Temp_min { get; set; }
        public float Temp_max { get; set; }
    }
}
