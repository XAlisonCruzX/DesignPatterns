namespace Strategy.Models
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }
        public ContaBancaria(double saldo)
        {
            this.Saldo = saldo;
        }
    }
}
