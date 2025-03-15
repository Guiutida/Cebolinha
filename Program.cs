string frase;

Console.WriteLine("Escreva uma frase como se ela fosse dita pelo Cebolinha, da Turma da Mônica");
Console.WriteLine();
Console.WriteLine("Exemplo: Eu gosto de carros e do formato da lua");
frase = Console.ReadLine();

Thread.Sleep(5000);
Console.Clear();

frase = frase
        .Replace("r", "l")
        .Replace("R", "L");

Console.WriteLine(frase);

