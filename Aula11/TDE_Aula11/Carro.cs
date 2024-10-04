using System.Security.Cryptography.X509Certificates;

public class Carro : Veiculo
{
    private int numDePortas;

    public Carro(string marca, string modelo, int ano, int numDePortas)
    :base(marca, modelo, ano)
    {
        this.numDePortas = numDePortas;
    }
    
    public void AbrirPortaMalas()
    {
        Console.WriteLine("O Porta malas está aberto");
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano: {ano}, Numero de portas: {numDePortas}");
    } 

}