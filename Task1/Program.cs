

void Main()
{
    int M = ReadInt("Введите нижнюю границу: ");
    int N = ReadInt("Введите верхнюю границу: ");
    PrintNumbers(M, N);
}

void PrintNumbers(int M, int N)
{
    if(M == N + 1) return;
    
    System.Console.Write(M + " ");
    PrintNumbers(M + 1, N);
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();