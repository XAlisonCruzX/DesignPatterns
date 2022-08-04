using Strategy.Interfaces;
using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Service
{
    public class CalculadorDeImposto
    {
        public double CalculaImposto(Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcular(orcamento);
        }
    }
}
