int x = 1;

while (x == 1)
{
    Console.WriteLine("Digite sua idade: ");
    int idade = int.Parse(Console.ReadLine());

    if (idade >= 18)
    {
        Console.WriteLine("Está apto a dirigir");
        x++;
    }
    else
    {
        Console.WriteLine("Não possui 18 anos");
    }
}