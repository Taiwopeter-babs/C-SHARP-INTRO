void ListChallenge()
{
    int limit = 20;
    var fibinacciNums = new List<int> {1, 1};
    int newItem;

    for (int i = fibinacciNums.Count; i < limit; i++)
    {
        newItem = fibinacciNums[i - 1] + fibinacciNums[i - 2];
        fibinacciNums.Add(newItem);
    }

    foreach (var item in fibinacciNums)
    {
        Console.WriteLine(item);
    }
}
ListChallenge();

