using Strategy.Interfaces;
using Strategy.Models;

namespace Strategy.Strategy
{
    public class ICCC : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            var valor = orcamento.Valor;

            if (valor < 1000.0)
                return valor * 0.05;
            else if (valor >= 1000.0 || valor < 3000)
                return valor * 0.07;
            else
                return 30.0 + (valor * 0.08);
        }
    }
}
