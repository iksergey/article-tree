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

  /// <summary>
  /// Прямой обход или корень-левый-правый
  /// </summary>
  public string PreOrder()
  {
    sb.Clear();
    PreOrder(this.node, sb);
    return sb.ToString();
  }

  private void PreOrder(BinaryTreeNode<T> node,
                        StringBuilder sb)
  {
    if (node != null)
    {
      sb.Append($"{node.Value} ");
      PreOrder(node.Left, sb);
      PreOrder(node.Right, sb);
    }
  }

  /// <summary>
  /// Центрированный обход или корень-левый-правый
  /// </summary>
  public string InOrder()
  {
    sb.Clear();
    InOrder(this.node, sb);
    return sb.ToString();
  }

  private void InOrder(BinaryTreeNode<T> node,
                       StringBuilder sb)
  {
    if (node != null)
    {
      InOrder(node.Left, sb);
      sb.Append($"{node.Value} ");
      InOrder(node.Right, sb);
    }
  }

  /// <summary>
  /// Обратный обход или корень-левый-правый
  /// </summary>
  public string PostOrder()
  {
    sb.Clear();
    PostOrder(this.node, sb);
    return sb.ToString();
  }

  private void PostOrder(BinaryTreeNode<T> node,
                        StringBuilder sb)
  {
    if (node != null)
    {
      PostOrder(node.Left, sb);
      PostOrder(node.Right, sb);
      sb.Append($"{node.Value} ");
    }
  }

  /// <summary>
  /// Прямой обход и скобочное представление
  /// </summary>
  public string BracketsPreOrder()
  {
    sb.Clear();
    BracketsPreOrder(this.node, sb);
    return sb.ToString();
  }

  private void BracketsPreOrder(BinaryTreeNode<T> node,
                                StringBuilder sb)
  {
    if (node != null)
    {
      sb.Append($"{node.Value}");
      if (node.Left != null || node.Right != null)
      {
        sb.Append("(");
        if (node.Left != null) BracketsPreOrder(node.Left, sb);
        else sb.Append("-");
        sb.Append(";");
        if (node.Right != null) BracketsPreOrder(node.Right, sb);
        else sb.Append("-");
        sb.Append(")");
      }
    }
  }

}