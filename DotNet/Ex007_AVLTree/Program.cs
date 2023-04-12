public class Program
{
  static void Main(string[] args)
  {
    for (int j = 10; j <= 20; j++)
    {
      AVLTree<int> tree = new();
      var n = Math.Pow(2, j) - 1;
      for (int i = 0; i < n; i++) tree.Append(i);
      Console.WriteLine(String.Format(
        "AVLTree.Height: {0,-2} -> n: {1}",
        tree.Root.Height,
        n
      ));
      File.WriteAllText($"tree{n}.txt", tree.ToString());
    }
  }
}