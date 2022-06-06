Console.WriteLine("Digite sua nota");
double nota = double.Parse(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine("aprovado");
}  
else if (nota >= 5 && nota < 7)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}

/*string aprovacao = nota >= 7 ? "aprovado" : "reprovado";

Console.WriteLine(aprovacao);*/
