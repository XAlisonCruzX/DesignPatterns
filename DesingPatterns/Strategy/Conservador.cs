using Strategy.Interfaces;
using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    public class Conservador : IInvestimento
    {
        public double Investir(double valor)
        {
            return valor * 0.008;
        }
    }
}
