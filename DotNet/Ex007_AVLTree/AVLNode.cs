public class AVLNode<T>
{
  public T Value { get; set; }
  public AVLNode<T> Left { get; set; }
  public AVLNode<T> Right { get; set; }
  public int Height { get; private set; }
  public int BalanceFactor => HeightDiff(Left, Right);

  public AVLNode(T value) { Value = value; Height = 1; }

  public void UpdateHeight() =>
  Height = 1 + Math.Max(GetHeight(Left), GetHeight(Right));

  private int HeightDiff(AVLNode<T> left, AVLNode<T> right) =>
  GetHeight(left) - GetHeight(right);

  private int GetHeight(AVLNode<T> node) =>
  node == null ? 0 : node.Height;
}