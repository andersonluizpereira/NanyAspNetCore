﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nsncy.Models
{
    public static class Config
    {
        public static IConfiguration Configurations { get; set; }
    }
}
