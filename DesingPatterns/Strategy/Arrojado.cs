using Strategy.Interfaces;
using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    public class Arrojado : IInvestimento
    {
        public double Investir(double valor)
        {
            var chance = new Random().Next(101);

            if (chance <= 20)
                return valor * 0.05;

            if (chance > 30 || chance <= 50)
                return valor * 0.03;

            return valor * 0.006;
        }
    }
}
