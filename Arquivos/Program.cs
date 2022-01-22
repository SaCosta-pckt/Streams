using static System.Console;

var path = Path.Combine(Environment.CurrentDirectory,"teste.txt");

var sw = File.CreateText(path);
sw.WriteLine("Linha 1 teste teste");
sw.WriteLine("Linha 2 teste teste");
sw.Flush();