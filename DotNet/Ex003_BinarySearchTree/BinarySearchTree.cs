using System.Text;

public class BinarySearchTree<T>
where T : IComparable
{
  public BinaryTreeNode<T> Root { get; set; }

  public void Append(T value)
  {
    this.Root = Append(this.Root, value);
  }

  private BinaryTreeNode<T> Append(BinaryTreeNode<T> node, T value)
  {
    if (node == null) return new BinaryTreeNode<T>(value);
    int comp = value.CompareTo(node.Value);
    if (comp < 0) node.Left = Append(node.Left, value);
    else if (comp > 0) node.Right = Append(node.Right, value);
    return node;
  }

  private void TreeTraversal(BinaryTreeNode<T> node,
                               StringBuilder sb,
                               string sp = "")
  {
    if (node != null)
    {
      sb.Append($"{sp}{node.Value}\n");
      TreeTraversal(node.Left, sb, $"{sp}  ");
      TreeTraversal(node.Right, sb, $"{sp}  ");
    }
  }

  public override string ToString()
  {
    StringBuilder sb = new();
    TreeTraversal(this.Root, sb);
    return sb.ToString();
  }
}