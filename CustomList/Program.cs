using CustomList;

List<int> list = new List<int>();
GenericList<int> numbers3 = new();
numbers3.Add(1);
numbers3.Add(2);
numbers3.Add(3);
numbers3.Add(4);
Console.WriteLine($"{numbers3.Capacity} {numbers3.Count}");
numbers3.Add(5);
numbers3.Add(6);

Console.WriteLine($"{numbers3.Capacity} {numbers3.Count}");
numbers3.Remove(4);
Console.WriteLine($"{numbers3.Capacity} {numbers3.Count}");
foreach (int i in numbers3)
{
    Console.WriteLine(i);
}
Console.WriteLine(numbers3.Contains(5));
