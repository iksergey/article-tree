public class Program
{
  static void Main(string[] args)
  {
    BinarySearchTree<int> bst = new();
    int[] items = { 10, 5, 15, 3, 7, 20, 1, 4, 17, 30 };
    foreach (var item in items) bst.Append(item);

    foreach (var item in items)
    {
      bst.Remove(item);
      Console.WriteLine(bst.InOrder());
    }
  }
}