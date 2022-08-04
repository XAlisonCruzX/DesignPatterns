using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Interfaces
{
    public interface IInvestimento
    {
        double Investir(double valor);
    }
}
