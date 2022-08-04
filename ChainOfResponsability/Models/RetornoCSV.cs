using ChainOfResponsability.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Models
{
    public class RetornoCSV : ITratamento
    {
        public ITratamento? Proximo { get; set; }
        public RetornoCSV(ITratamento tratamento)
        {
            Proximo = tratamento;
        }
        public string Tratar(Requisicao req)
        {
            if (req.Formato == Formato.CSV)
                return "CSV";
            if(Proximo != null)
                return Proximo!.Tratar(req);

            return "";
        }
    }
}
