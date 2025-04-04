﻿decimal capital, taxa, meses, juros, montante;

Console.WriteLine("Juros simples (j)\n");
Console.ForegroundColor = ConsoleColor.Cyan;

Console.Write("Capital [c] (R$).......: ");
Console.ResetColor();
capital = Convert.ToDecimal(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Taxa de juros [i] (%)..: ");
Console.ResetColor();
taxa = Convert.ToDecimal(Console.ReadLine());
Console.ForegroundColor =ConsoleColor.Yellow;
Console.Write("Tempo [t] (meses)......: ");
Console.ResetColor();
meses = Convert.ToDecimal(Console.ReadLine());

juros = capital * (taxa / 100) * meses;
montante = capital + juros;

Console.WriteLine($"\nJuros.....: {juros:C2}");
Console.WriteLine($"Montante..: {montante:C2}");