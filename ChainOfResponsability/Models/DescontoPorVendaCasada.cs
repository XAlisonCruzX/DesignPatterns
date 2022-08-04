using ChainOfResponsability.Interfaces;
using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Models
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto? Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            bool vendaCasada = orcamento.Itens.Any(x => x.Nome == "Lapis") && orcamento.Itens.Any(x => x.Nome == "Caneta");
            if (vendaCasada)
                return orcamento.Valor * 0.05;

            return Proximo!.Desconta(orcamento);
        }
    }
}
