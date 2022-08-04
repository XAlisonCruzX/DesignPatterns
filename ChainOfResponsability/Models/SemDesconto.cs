using ChainOfResponsability.Interfaces;
using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Models
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public Double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
