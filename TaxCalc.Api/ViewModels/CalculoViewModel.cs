﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxCalc.Api.ViewModels
{
    public class CalculoViewModel
    {
        public decimal ValorInicial { get; set; }
        public int Tempo { get; set; }
        public decimal Resultado { get; set; }
    }
}
