public class MaximumAmount
{
  BinaryTree<int> tree;
  public MaximumAmount(BinaryTree<int> tree) => this.tree = tree;
  public int Calculate() => Calculate(this.tree.Root);
  private int Calculate(BinaryTreeNode<int> root)
  {
    if (root == null) return 0;
    int l = Calculate(root.Left);
    int r = Calculate(root.Right);
    return Math.Max(l, r) + root.Value;
  }
}