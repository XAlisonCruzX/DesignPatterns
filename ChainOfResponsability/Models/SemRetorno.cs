using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Models
{
    public class SemRetorno : ITratamento
    {
        public ITratamento Proximo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Tratar(Requisicao req)
        {
            return "";
        }
    }
}
