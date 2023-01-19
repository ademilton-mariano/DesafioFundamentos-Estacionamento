namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal xPrecoInicial = 0;
        private decimal xPrecoPorHora = 0;
        private List<string> xVeiculos = new List<string>();

        public Estacionamento(decimal pPrecoInicial, decimal pPrecoPorHora)
        {
            xPrecoInicial = pPrecoInicial;
            xPrecoPorHora = pPrecoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var xPlaca = Console.ReadLine();
            xVeiculos.Add(xPlaca);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            var xPlaca = Console.ReadLine();
            
            if (xVeiculos.Any(x => x.ToUpper() == xPlaca.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                var xHoras = Convert.ToInt32(Console.ReadLine());
                var valorTotal = xPrecoInicial + (xPrecoPorHora * xHoras);

                xVeiculos.Remove(xPlaca);

                Console.WriteLine($"O veículo {xPlaca} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }

        public void ListarVeiculos()
        {
            if (xVeiculos.Any())
                Console.WriteLine("Veículos estacionados: " + string.Join(" / ", xVeiculos) );
            else
                Console.WriteLine("Não há veículos estacionados.");
        }
    }
}