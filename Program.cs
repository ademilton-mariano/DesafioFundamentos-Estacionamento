using DesafioFundamentos.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal xPrecoInicial = 0;
decimal xPrecoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
xPrecoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
xPrecoPorHora = Convert.ToDecimal(Console.ReadLine());

var xEstacionamento = new Estacionamento(xPrecoInicial, xPrecoPorHora);

var xExibirMenu = true;

while (xExibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            xEstacionamento.AdicionarVeiculo();
            break;

        case "2":
            xEstacionamento.RemoverVeiculo();
            break;

        case "3":
            xEstacionamento.ListarVeiculos();
            break;

        case "4":
            xExibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");