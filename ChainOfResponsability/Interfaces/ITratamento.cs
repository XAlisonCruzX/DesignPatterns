using ChainOfResponsability.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Interfaces
{
    public interface ITratamento
    {
        public string Tratar(Requisicao req);
        ITratamento Proximo { get; set; }
    }
}
