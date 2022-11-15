// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

  IEnumerable<int> GetNumber()
{
    yield return 5;
    yield return 10;
    yield return 15;
    yield return 35;
}

var lst = GetNumber();
foreach (int i in GetNumber()) Console.WriteLine(i);  //5 10 15
