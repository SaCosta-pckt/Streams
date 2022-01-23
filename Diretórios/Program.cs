// See https://aka.ms/new-console-template for more information
using static System.Console;

var path = Path.Combine(Environment.CurrentDirectory, "globo");
CriarDiretoriosGlobo(path);
InfoDiretorios(path);

static void CriarDiretoriosGlobo(string path)
{

    if (!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);

        var dirAmerica = dirGlobo.CreateSubdirectory("Américas");
        var dirAsia = dirGlobo.CreateSubdirectory("Ásia");
        var dirAfrica = dirGlobo.CreateSubdirectory("África");
        var dirEuropa = dirGlobo.CreateSubdirectory("Europa");
        var dirOceania = dirGlobo.CreateSubdirectory("Oceania");

        dirAmerica.CreateSubdirectory("Brasil");
        dirAmerica.CreateSubdirectory("Canada");
        dirAmerica.CreateSubdirectory("Argentina");

        dirAsia.CreateSubdirectory("Japao");
        dirAsia.CreateSubdirectory("China");

        dirAfrica.CreateSubdirectory("Nigeria");
        dirAfrica.CreateSubdirectory("Marrocos");

        dirEuropa.CreateSubdirectory("França");
        dirEuropa.CreateSubdirectory("Portugal");

        dirOceania.CreateSubdirectory("Palau");
        dirOceania.CreateSubdirectory("Australia");

        WriteLine("Diretórios criados com sucesso!");
    }

    else
    {
        WriteLine("Os diretórios já existem!");
    }
}

static void InfoDiretorios(string path)
{
    if(Directory.Exists(path)){
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        foreach (var dir in diretorios)
        {   
            var dirInfo = new DirectoryInfo(dir);
            WriteLine("Nome:" + dirInfo.Name);
            WriteLine("Raiz:" + dirInfo.Root);
            if (dirInfo.Parent != null) {
                WriteLine("Pai:" + dirInfo.Parent.Name);
            }
        }
    }
}


