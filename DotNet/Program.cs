public class Program
{
  static void Main(string[] args)
  {
    TreeNode<int> node1 = new(1);
    TreeNode<int> node2 = new(2);
    TreeNode<int> node3 = new(3);
    TreeNode<int> node4 = new(4);
    TreeNode<int> node5 = new(5);
    TreeNode<int> node6 = new(6);

    node1.Children.Add(node4);

    node4.Children.Add(node2);
    node4.Children.Add(node3);
    node4.Children.Add(node5);

    node5.Children.Add(node6);
    Tree<int> tree = new() { Root = node1 };

    Console.WriteLine(tree.Print());
  }
}