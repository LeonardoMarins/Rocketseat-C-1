using System;

Console.WriteLine("qual formato você quer sua data ?");
Console.WriteLine("1- formato completo");
Console.WriteLine("2- Apenas a data no formato 01/03/2024.");
Console.WriteLine("3- Apenas a hora no formato de 24 horas.");
Console.WriteLine("4- A data com o mês por extenso.");
var opcao = Console.ReadLine();

var op = Convert.ToInt32(opcao);

switch(op)
{
    case 1:
        DateTime now = DateTime.Now;
        Console.WriteLine("Data e hora atual:");
        Console.WriteLine(now.ToString("dddd, dd/MM/yyyy HH:mm:ss"));
        break;
    case 2:
        DateTime nowDate = DateTime.UtcNow;
        Console.WriteLine(nowDate.ToString("dd/MM/yyyy"));
        break;
    case 3:
        DateTime nowTime = DateTime.UtcNow;
        Console.WriteLine(nowTime.ToString("HH:mm:ss"));
        break;
    case 4:
        DateTime nowweek = DateTime.UtcNow;
        Console.WriteLine(nowweek.ToString("dd/MMMM/yyyy"));
        break;
}