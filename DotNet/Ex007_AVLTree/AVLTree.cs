using System.Text;

public partial class AVLTree<T>
where T : IComparable<T>
{
  public AVLNode<T> Root { get; private set; }

  private AVLNode<T> RotateLeft(AVLNode<T> node)
  {
    AVLNode<T> r = node.Right;
    AVLNode<T> rl = r.Left;
    r.Left = node;
    node.Right = rl;
    node.UpdateHeight();
    r.UpdateHeight();
    return r;
  }
  private AVLNode<T> RotateRight(AVLNode<T> node)
  {
    AVLNode<T> l = node.Left;
    AVLNode<T> lr = l.Right;
    l.Right = node;
    node.Left = lr;
    node.UpdateHeight();
    l.UpdateHeight();
    return l;
  }



  public void Append(T value) { Root = Append(Root, value); }

  private AVLNode<T> Append(AVLNode<T> node, T value)
  {
    if (node == null) return new AVLNode<T>(value);
    int comp = value.CompareTo(node.Value);
    if (comp < 0) node.Left = Append(node.Left, value);
    else if (comp > 0) node.Right = Append(node.Right, value);
    node.UpdateHeight();
    if (node.BalanceFactor > 1)
    {
      if (node.Left.BalanceFactor < 0)
        node.Left = RotateLeft(node.Left);
      return RotateRight(node);
    }
    if (node.BalanceFactor < -1)
    {
      if (node.Right.BalanceFactor > 0)
        node.Right = RotateRight(node.Right);
      return RotateLeft(node);
    }
    return node;
  }

  public bool Remove(T value)
  {
    bool removed = false;
    Root = Remove(Root, value, ref removed);
    return removed;
  }

  private AVLNode<T> Remove(AVLNode<T> node,
                            T value,
                            ref bool removed)
  {
    if (node == null) return null;
    int comp = value.CompareTo(node.Value);
    if (comp < 0) node.Left = Remove(node.Left, value, ref removed);
    else if (comp > 0) node.Right = Remove(node.Right, value, ref removed);
    else
    {
      removed = true;
      if (node.Left == null) return node.Right;
      else if (node.Right == null) return node.Left;
      AVLNode<T> maxLeft = Max(node.Left);
      node.Value = maxLeft.Value;
      node.Left = Remove(node.Left, maxLeft.Value, ref removed);
    }

    if (removed)
    {
      node.UpdateHeight();
      if (node.BalanceFactor > 1)
      {
        if (node.Left.BalanceFactor < 0) node.Left = RotateLeft(node.Left);
        return RotateRight(node);
      }
      if (node.BalanceFactor < -1)
      {
        if (node.Right.BalanceFactor > 0) node.Right = RotateRight(node.Right);
        return RotateLeft(node);
      }
    }
    return node;
  }


  private AVLNode<T> Max(AVLNode<T> node)
  {
    if (node == null) return null;
    if (node.Right == null) return node;
    else return Max(node.Right);
  }

  private void TreeTraversal(AVLNode<T> node,
                                StringBuilder sb,
                                string sp = "")
  {
    if (node != null)
    {
      sb.Append($"{sp}{node.Value,3}\n");
      TreeTraversal(node.Left, sb, $"{sp}    ");
      TreeTraversal(node.Right, sb, $"{sp}    ");
    }
  }

  public override string ToString()
  {
    StringBuilder sb = new();
    TreeTraversal(this.Root, sb);
    return sb.ToString();
  }

}