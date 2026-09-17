
Console.WriteLine("Vamos falar baleiês?? Digite algo para traduzir para baleiês: ");
string frase = Console.ReadLine();
List<char> vogais = new List<char> { 'a', 'e', 'i', 'o', 'u' };
if (vogais.Any(x => frase.Contains(x)))
{
    if (frase.Contains('a'))
    {
        frase = frase.Replace("a", "aaa");
    }
    if (frase.Contains('e'))
    {
        frase = frase.Replace("e", "eee");
    }
    if (frase.Contains('i'))
    {
        frase = frase.Replace("i", "iii");
    }
    if (frase.Contains('o'))
    {
        frase = frase.Replace("o", "ooo");
    }
    if (frase.Contains('u'))
    {
        frase = frase.Replace("u", "uuu");
    }
}

Console.WriteLine($"A frase em baleiês é: {frase}");





