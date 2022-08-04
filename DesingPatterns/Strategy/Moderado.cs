using Strategy.Interfaces;
using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    public class Moderado : IInvestimento
    {
        public double Investir(double valor)
        {
            var chance = new Random().Next(101);

            if (chance <= 50)
                return valor * 0.025;

            return valor * 0.007;
        }
    }
}
