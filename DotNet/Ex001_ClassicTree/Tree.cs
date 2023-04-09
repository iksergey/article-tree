using System.Text;

public class Tree<T>
{
  public TreeNode<T> Root { get; set; }

  public string Print()
  {
    StringBuilder sb = new();
    TreeTraversal(this.Root, sb);
    return sb.ToString();
  }

  private void TreeTraversal<T>(TreeNode<T> node,
                                StringBuilder sb,
                                string sp = "")
  {
    if (node != null)
    {
      sb.Append($"{sp}[{node.Value}]\n");
      foreach (var child in node.Children)
      {
        TreeTraversal(child, sb, $"{sp}  ");
      }
    }
  }

  public override string ToString()
  {
    StringBuilder sb = new();
    TreeTraversal(this.Root, sb);
    return $"[{sb.ToString()
                  .Replace(" ", "")
                  .Replace("\n", "")
                  .Replace("][", ", ")
                  .Replace("[", "")
                  .Replace("]", "")}]";
  }
}