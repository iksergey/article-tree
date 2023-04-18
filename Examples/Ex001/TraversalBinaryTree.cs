using System.Text;

public class TraversalBinaryTree<T>
{
  BinaryTreeNode<T> node;
  StringBuilder sb;
  public TraversalBinaryTree(BinaryTree<T> tree)
  {
    this.node = tree.Root;
    this.sb = new();
  }

  public string PreOrder()
  {
    sb.Append("\n");
    PreOrder(this.node, sb);
    return sb.ToString();
  }

  private void PreOrder(BinaryTreeNode<T> node,
                                StringBuilder sb,
                                string sp = "")
  {
    if (node != null)
    {
      sb.Append($"{sp}{node.Value}\n");
      PreOrder(node.Left, sb, sp + "  ");
      PreOrder(node.Right, sb, sp + "  ");
    }
  }
}