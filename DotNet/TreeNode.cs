public class TreeNode<T>
{
  public List<TreeNode<T>> Children { get; set; }
  public T Value { get; }
  public TreeNode(T value)
  {
    this.Value = value;
    this.Children = new();
  }
}