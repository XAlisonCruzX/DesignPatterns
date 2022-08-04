using ChainOfResponsability.Models;
using ChainOfResponsability.Service;
using Strategy.Models;

public class TestaDescontos
{
    static void Main(string[] args)
    {
        var calculador = new CalculadorDeDescontos();
        var orcamento = new Orcamento(500.0);
        orcamento.AdicionaItem(new Item("CANETA", 250.0));
        orcamento.AdicionaItem(new Item("LAPIS", 251.0));


        double desconto = calculador.Calcula(orcamento);

        Console.WriteLine(desconto);
    }
}