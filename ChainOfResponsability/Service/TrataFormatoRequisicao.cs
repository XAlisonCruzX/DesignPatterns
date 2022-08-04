using ChainOfResponsability.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Service
{
    public class TrataFormatoRequisicao
    {
        public string TratarRequisicao(Requisicao req)
        {                     
            var t3 = new RetornoPORCENTO(null);
            var t2 = new RetornoXML(t3);
            var t1 = new RetornoCSV(t2);

            return t1.Tratar(req);
        }
    }
}
