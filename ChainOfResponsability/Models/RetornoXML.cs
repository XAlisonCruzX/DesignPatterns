using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Models
{
    public class RetornoXML : ITratamento
    {
        public ITratamento Proximo { get; set; }
        public RetornoXML(ITratamento tratamento)
        {
            Proximo = tratamento;
        }
        public string Tratar(Requisicao req)
        {
            if(req.Formato == Formato.XML)
                return "XML";

            if (Proximo != null)
                return Proximo!.Tratar(req);

            return "";
        }
    }
}
