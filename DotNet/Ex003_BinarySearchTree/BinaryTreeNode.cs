public class BinaryTreeNode<T>
{
  public BinaryTreeNode<T> Left { get; set; }
  public BinaryTreeNode<T> Right { get; set; }
  public T Value { get; set; }

  public BinaryTreeNode(T value)
  {
    this.Left = null;
    this.Right = null;
    this.Value = value;
  }
}