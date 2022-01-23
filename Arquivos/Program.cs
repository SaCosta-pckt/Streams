using static System.Console;

WriteLine("Escreva o nome do arquivo:");
var nome = LimparNome(ReadLine());

var path = Path.Combine(Environment.CurrentDirectory,$"{nome}.txt");


CriarArquivo(path);
WriteLine("Digite enter para finalizar...");
ReadLine();

static void CriarArquivo(string path){
    //Escrever "using" faz com que o programa dê o "flush"(descargue as linhas escritas na memória pro arquivo) automaticamente

    try{
        using var sw = File.CreateText(path);
        sw.WriteLine("Linha 1 teste teste");
        sw.WriteLine("Linha 2 teste teste");
    }

    catch{
        WriteLine("Nome de arquivo inválido!");
    }
}

static string LimparNome(string nome)
{
    //Evitar criação de arquivo com nome inválido
    foreach (var caractere in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(caractere,'-');
    }
    return nome;
}
