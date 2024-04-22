int tamanho = 10;
char[] letras = new char[tamanho];

for (int i = 0; i < tamanho; i++)
{
    letras[i] = char.Parse(Console.ReadLine());
}

Console.Write("Entrada: ");
for (int i = 0; i < tamanho; i++)
{
    Console.Write($" {letras[i]} ");
    switch (letras[i])
    {
        case 'a':
            letras[i] = 'A';
            break;
        case 'e':
            letras[i] = 'E';
            break;
        case 'i':
            letras[i] = 'I';
            break;
        case 'o':
            letras[i] = 'O';
            break;
        case 'u':
            letras[i] = 'U';
            break;
        default:
            break;
    }
}

Console.WriteLine();

Console.Write("Saída: ");
for (int i = 0; i < tamanho; i++)
{
    Console.Write($" {letras[i]} ");
}

Console.WriteLine();
Console.WriteLine("Pressione Enter para encerrar...");
Console.ReadLine();