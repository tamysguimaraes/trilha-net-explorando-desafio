namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    public List<Pessoa> CadastrarHospedes(int qtde)
    {
        List<Pessoa> hospedes = new List<Pessoa>();
        // Cria os modelos de hóspedes e cadastra na lista de hóspedes
        for (int i=1;i<=qtde;i++)
        {
            Console.WriteLine("Digite o nome da pessoa");
            hospedes.Add(new Pessoa(nome: Console.ReadLine()));
        }
        return hospedes;
    }
}