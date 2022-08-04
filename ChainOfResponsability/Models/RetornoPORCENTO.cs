using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Models
{
    public class RetornoPORCENTO : ITratamento
    {
        public ITratamento? Proximo { get; set; }
        public RetornoPORCENTO(ITratamento tratamento)
        {
            Proximo = tratamento;
        }
        public string Tratar(Requisicao req)
        {
            if (req.Formato == Formato.PORCENTO)
                return "%";

            if (Proximo != null)
                return Proximo!.Tratar(req);

            return "";
        }
    }
}
