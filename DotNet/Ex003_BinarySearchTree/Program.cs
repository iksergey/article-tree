public class Program
{
  static void Main(string[] args)
  {
    var bst = new BinarySearchTree<int>();
    int[] items = { 10, 5, 15, 3, 7, 20 };
    foreach (var item in items) bst.Append(item);
    Console.WriteLine(bst);
  }
}