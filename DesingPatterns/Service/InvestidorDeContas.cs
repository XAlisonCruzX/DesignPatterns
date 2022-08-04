using Strategy.Interfaces;
using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Service
{
    public class InvestidorDeContas
    {
        public double InvestirSaldoDaConta(ContaBancaria conta, IInvestimento investimento)
        {
            var lucro = investimento.Investir(conta.Saldo);
            return lucro * 0.75;
        }
    }
}
