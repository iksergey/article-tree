public class Program
{
  static void Main(string[] args)
  {
    var bst = new BinarySearchTree<int>();
    int[] items = { 10, 5, 15, 3, 7, 20 };
    foreach (var item in items) bst.Append(item);

    int[] findItems = { 10, 20, 30, 3, 6, 9 };

    var result = findItems.Select(e => (e, bst.Search(e) != null));
    Console.WriteLine(String.Join('\n', result));

    var contains = findItems.Select(e => (e, bst.Contains(e)));
    Console.WriteLine(String.Join('\n', contains));

    Console.WriteLine("---");

    bst = new BinarySearchTree<int>();
    items = new[] { 10, 5, 15, 3, 7, 20, 1, 4, 17, 30, 40 };
    foreach (var item in items) bst.Append(item);
    Console.WriteLine(bst);
    Console.WriteLine($"bst.Min() = {bst.Min()?.Value}");
    Console.WriteLine($"bst.Max() = {bst.Max()?.Value}");
    Console.WriteLine($"bst.MinLoop() = {bst.MinLoop()?.Value}");
    Console.WriteLine($"bst.MaxLoop() = {bst.MaxLoop()?.Value}");
  }
}