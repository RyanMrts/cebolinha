
string frasedigitada, frasecebolinha;



Console.WriteLine("Digite uma frase: ");
frasedigitada = Console.ReadLine()!;

frasecebolinha = frasedigitada
.Replace("r", "l")
.Replace("R", "L");
Console.WriteLine(frasecebolinha);




