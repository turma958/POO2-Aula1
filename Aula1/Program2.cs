//var aluno = new Aluno();
//aluno.Nome = "Davi";
//aluno.Email = "davi@teste.com";

//var professor = new Professor();
//professor.Nome = "Davi prof";
//professor.Email = "davi@teste.com";

////aluno.Salvar();
//Printar(aluno);
//Printar(professor);

//Console.ReadLine();

//void Printar(Pessoa pessoa)
//{
//    //Console.WriteLine($"{pessoa.Nome} - {pessoa.Email}");
//    pessoa.ExibirInformacoes();
//}

//abstract class Pessoa
//{
//    // Atributos
//    public string Nome { get; set; }
//    public string CPF { get; set; }
//    public string Email { get; set; }
//    public string Senha { get; set; }

//    // Ações
//    public abstract void ExibirInformacoes();
//}

//class Aluno : Pessoa
//{
//    public int Nota { get; set; }

//    public override void ExibirInformacoes()
//    {
//        Console.WriteLine($"{Nome} - {Nota}");
//    }
//}

//class Professor : Pessoa
//{
//    public override void ExibirInformacoes()
//    {
//        Console.WriteLine($"{Nome} - {Email}");
//    }
//}