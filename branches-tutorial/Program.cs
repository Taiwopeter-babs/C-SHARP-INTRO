void Challenge()
{
    int i, sum = 0;

    for (i  = 1; i <= 20; i++)
    {
        if (i % 3 == 0)
        {
            sum += i;
        }
    }
    Console.WriteLine(sum);
}

int Main(string[] args)
{
    Console.WriteLine(args);
    Challenge();
    return 0;
}

Main();