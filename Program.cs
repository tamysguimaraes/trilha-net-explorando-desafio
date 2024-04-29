using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

string opcao = string.Empty;
bool exibirMenu = true;
Pessoa pessoa= new Pessoa();
Suite suite = new Suite();
List<Pessoa> hospedes = new List<Pessoa>();


// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar hóspedes");
    Console.WriteLine("2 - Cadastrar Suíte");
    Console.WriteLine("3 - Cadastrar Reserva");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Quantas pessoas serão cadastradas");
            int qtde = Convert.ToInt32(Console.ReadLine());
            hospedes=pessoa.CadastrarHospedes(qtde);
            break;

        case "2":
            // Cria a suíte
            Console.WriteLine("Tipo de Suite");
            string tipo = Console.ReadLine();
            Console.WriteLine("Capacidade");
            int capacidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor Diária");
            int valorDia = Convert.ToInt32(Console.ReadLine());
            suite = new Suite(tipoSuite: tipo, capacidade: capacidade, valorDiaria: valorDia);
            break;

        case "3":
            Console.WriteLine("Dias de Reserva");
            Reserva reserva = new Reserva(diasReservados: Convert.ToInt32(Console.ReadLine()));
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            if(reserva.Hospedes==null)
            Console.WriteLine($"Quantidade de hóspedes {hospedes.Count} maior do que o permitido {suite.Capacidade}");
            else{
            // Exibe a quantidade de hóspedes e o valor da diária
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
            }
            
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");






