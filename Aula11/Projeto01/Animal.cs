public class Animal
{
    public string nome;
   // public int idade;
    private int idade;

    public void SetIdade(int idade)
    {
        if(idade >= 0)
        {
            this.idade = idade;
        }
        else
        {
            Console.WriteLine("Valor inválido");
        }
    }
    public int GetIdade()
    {
        return idade;
    }
    
    public void Comer()
    {
        Console.WriteLine($"{nome} está comendo!");
    }
}