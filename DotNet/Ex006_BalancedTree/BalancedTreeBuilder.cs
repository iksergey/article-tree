public class BalancedTreeBuilder<T>
{
  T[] args;
  int index;

  public BinaryTreeNode<T> Get(params T[] args)
  {
    this.args = args;
    this.index = -1;
    return Create(args.Length);
  }

  public BinaryTreeNode<T> Create(int n)
  {
    BinaryTreeNode<T> node = null;

    if (n > 0)
    {
      node = new(this.args[++index]);
      node.Left = Create(n / 2);
      node.Right = Create(n - (n / 2) - 1);
    }
    return node;
  }
}