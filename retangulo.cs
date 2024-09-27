Retangulo R1 = new Retangulo();
Retangulo R2 = new Quadrado(5);
Retangulo R3 = new Retangulo(4, 6);

Console.Writeline($"A area do retangulo R1 é igual {R1.CalcularArea()}");
Console.Writeline($"O perimetro do retangulo R1 é igual {R1.CalcularPerimetro()}");

Console.Writeline($"A area do retangulo R2 é igual {R2.CalcularArea()}");
Console.Writeline($"O perimetro do retangulo R2 é igual {R2.CalcularPerimetro()}");

Console.Writeline($"A area do retangulo R3 é igual {R3.CalcularArea()}");
Console.Writeline($"O perimetro do retangulo R3 é igual {R3.CalcularPerimetro()}");

R3.Redimensionar(2);

Console.Writeline($"A area do retangulo R3 é igual {R3.CalcularArea()}");
Console.Writeline($"O perimetro do retangulo R3 é igual {R3.CalcularPerimetro()}");

R3.Redimensionar(10,15);

Console.Writeline($"A area do retangulo R2 é igual {R2.CalcularArea()}");
Console.Writeline($"O perimetro do retangulo R2 é igual {R2.CalcularPerimetro()}");
