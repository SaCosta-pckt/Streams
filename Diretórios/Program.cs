// See https://aka.ms/new-console-template for more information
using static System.Console;

CriarDiretoriosGlobo();

static void CriarDiretoriosGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");

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


