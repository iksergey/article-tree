public class Program
{
  static void Main(string[] args)
  {
    var n = 2;//Random.Shared.Next(5, 15);
    var builder = new BalancedTreeBuilder<int>();
    var items = Enumerable.Range(1, n).ToArray();
    var bt = new BalancedTree<int>(builder.Get(items));
    var output = $"n: {n}\nitems = {string.Join(' ', items)}\n{bt}";
    Console.WriteLine(output);
  }
}