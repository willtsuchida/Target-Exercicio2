Console.Write("Digite um valor (inteiro) para verificar se ele está contido na sequência Fibonacci: ");
int numero = int.Parse(Console.ReadLine());

List<int> a = sequencia(numero);
imprimirFibonacci(numero);

if (a.Contains(numero))
{
    Console.WriteLine($"\nO número {numero} está contido na sequencia Fibonacci!");
}
else
{
    Console.WriteLine($"\nO número {numero} NÃO está contido na sequencia Fibonacci!");
}

static void imprimirFibonacci(int tamanho)
{
    Console.WriteLine("Imprimindo sequência Fibonacci: ");

    for (int comeco = 0, meio = 1, fim = 0; fim <= tamanho;)
    {

        Console.Write($"{fim} ");

        if (fim == 1)
        {
            Console.Write($"{fim} ");
        }

        fim = comeco + meio;
        comeco = meio;
        meio = fim;

    }
}
static List<int> sequencia(int tamanho)
{
    List<int> fibonacci = new List<int>();

    for (int comeco = 0, meio = 1, fim = 0; comeco <= tamanho;)
    {
        fibonacci.Add(comeco);

        fim = comeco + meio;
        comeco = meio;
        meio = fim;

    }
    return fibonacci;
}