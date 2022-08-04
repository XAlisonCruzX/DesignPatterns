using ChainOfResponsability.Models;
using ChainOfResponsability.Service;

namespace ChainOfResponsability
{
    public class TestaTratamento
    {
        static void Main(string[] args)
        {
            var requisicao = new Requisicao(Formato.XML);
            var requisicao2 = new Requisicao(Formato.CSV);
            var requisicao3 = new Requisicao(Formato.PORCENTO);
            var tratador = new TrataFormatoRequisicao();

            Console.WriteLine(tratador.TratarRequisicao(requisicao));
            Console.WriteLine(tratador.TratarRequisicao(requisicao2));
            Console.WriteLine(tratador.TratarRequisicao(requisicao3));

        }
    }
}
