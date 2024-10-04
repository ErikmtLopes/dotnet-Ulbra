Cachorro cachorro = new Cachorro();
cachorro.nome = "Gaia";
cachorro.SetIdade(4);
cachorro.Comer();
cachorro.Latir();

Console.WriteLine("Idade do Cachorro: " + cachorro.GetIdade());

Gato gato = new Gato();
gato.nome = "Miau";
gato.SetIdade (9);
gato.numVidas = 7;
gato.Comer();
gato.Miar();

Console.WriteLine("Idade do Gato: " + gato.GetIdade());
