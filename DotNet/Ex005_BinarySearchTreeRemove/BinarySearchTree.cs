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

  public BinaryTreeNode<T> Search(T value)
  {
    return Search(this.Root, value);
  }

  public bool Contains(T value)
  {
    return Search(this.Root, value) != null;
  }

  private BinaryTreeNode<T> Search(BinaryTreeNode<T> node, T value)
  {
    if (node == null) return null;
    return node.Value.CompareTo(value) switch
    {
      0 => node,
      > 0 => Search(node.Left, value),
      < 0 => Search(node.Right, value)
    };
  }

  public BinaryTreeNode<T> Min()
  {
    return Min(this.Root);
  }

  private BinaryTreeNode<T> Min(BinaryTreeNode<T> node)
  {
    if (node == null) return null;
    if (node.Left == null) return node;
    else return Min(node.Left);
  }

  public BinaryTreeNode<T> Max()
  {
    return Max(this.Root);
  }

  private BinaryTreeNode<T> Max(BinaryTreeNode<T> node)
  {
    if (node == null) return null;
    if (node.Right == null) return node;
    else return Max(node.Right);
  }

  public BinaryTreeNode<T> MinLoop()
  {
    BinaryTreeNode<T> node = this.Root;
    while (node?.Left != null) node = node.Left;
    return node;
  }

  public BinaryTreeNode<T> MaxLoop()
  {
    BinaryTreeNode<T> node = this.Root;
    while (node?.Right != null) node = node.Right;
    return node;
  }

  public void Remove(T value)
  {
    this.Root = Remove(this.Root, value);
  }

  private BinaryTreeNode<T> Remove(BinaryTreeNode<T> node,
                                      T value)
  {
    if (node == null) return null;
    int comp = value.CompareTo(node.Value);
    if (comp < 0) node.Left = Remove(node.Left, value);
    else if (comp > 0) node.Right = Remove(node.Right, value);
    else
    {
      if (node.Left == null) return node.Right;
      else if (node.Right == null) return node.Left;
      // BinaryTreeNode<T> minRight = Min(node.Right);
      BinaryTreeNode<T> maxLeft = Max(node.Left);
      // node.Value = minRight.Value;
      node.Value = maxLeft.Value;
      // node.Right = Remove(node.Right, minRight.Value);
      node.Left = Remove(node.Left, maxLeft.Value);
    }
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