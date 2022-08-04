using Strategy.Models;
using Strategy.Service;
using Strategy.Strategy;

var ocamento = new Orcamento(3001.0);
var calculador = new CalculadorDeImposto();
Console.WriteLine(calculador.CalculaImposto(ocamento, new ICCC()));
