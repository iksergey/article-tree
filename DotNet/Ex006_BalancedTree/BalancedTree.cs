using System.Text;

public class BalancedTree<T>
{
  public BinaryTreeNode<T> Root { get; set; }
  public BalancedTree(BinaryTreeNode<T> root)
  {
    this.Root = root;
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
