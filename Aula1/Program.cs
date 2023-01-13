var leao = new Leao
{
    Nome = "Lion",
    Idade = 16
};

var leaoFilho = new Leao
{
    Nome = "Lion filho",
    Idade = 1
};

Amamentar(leao, leaoFilho);
Console.ReadLine();

var reino = new Rinoceronte
{
    Nome = "Dino",
    Idade = 22
};

void Amamentar(Mamifero mae, Mamifero filho)
{
    mae.Amamentar();
    filho.Mamar();
}

abstract class Animalia
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

abstract class Mamifero : Animalia
{
    public void Mamar()
    {
        Console.WriteLine("Mamando");
    }

    public void Amamentar()
    {
        Console.WriteLine("Amamentando");
    }

    public void Comer()
    {
        Console.WriteLine($"Eu como: {ObterTipoAlimento()}");
    }

    public abstract string ObterTipoAlimento();
}

abstract class Carnivoro : Mamifero
{
}

abstract class Herbivoro : Mamifero
{
}

class Leao : Carnivoro
{
    public override string ObterTipoAlimento()
    {
        return "antilopes!";
    }
}

class Jacare : Carnivoro
{
    public override string ObterTipoAlimento()
    {
        return "peixes!";
    }
}

class Rinoceronte : Herbivoro
{
    public override string ObterTipoAlimento()
    {
        return "plantas!";
    }
}

class Coelho : Herbivoro
{
    public override void Comer()
    {
        Console.WriteLine("Eu como grama!");
    }
}