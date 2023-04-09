using static System.Console;

public class Program
{
  static void Main(string[] args)
  {


    #region Traversals
    var nodes = Enumerable.Range(0, 11)
                          .Select(e => new BinaryTreeNode<int>(e))
                          .ToArray();

    nodes[1].Left = nodes[2];
    nodes[2].Left = nodes[4];
    nodes[2].Right = nodes[5];
    nodes[5].Right = nodes[9];

    nodes[1].Right = nodes[3];
    nodes[3].Left = nodes[6];
    nodes[3].Right = nodes[7];
    nodes[7].Right = nodes[8];
    nodes[8].Left = nodes[10];

    BinaryTree<int> bt = new() { Root = nodes[1] };
    var t = new TraversalBinaryTree<int>(bt);
    WriteLine($"PreOrder: {t.PreOrder()}");
    WriteLine($"InOrder: {t.InOrder()}");
    WriteLine($"PostOrder: {t.PostOrder()}");
    #endregion

    #region BracketsPreOrder Traversal
    WriteLine($"BracketsPreOrder: {t.BracketsPreOrder()}");

    ReadLine();
    Clear();

    nodes = Enumerable.Range(0, 5)
                              .Select(e => new BinaryTreeNode<int>(e))
                              .ToArray();
    nodes[0].Left = nodes[1];
    nodes[0].Right = nodes[2];
    nodes[1].Left = nodes[3];
    nodes[1].Right = nodes[4];
    bt = new() { Root = nodes[0] };
    t = new TraversalBinaryTree<int>(bt);
    WriteLine($"BracketsPreOrder: {t.BracketsPreOrder()}");


    ReadLine();
    Clear();

    nodes = Enumerable.Range(0, 5)
                              .Select(e => new BinaryTreeNode<int>(e))
                              .ToArray();
    nodes[0].Left = nodes[1];
    nodes[0].Right = nodes[2];
    nodes[1].Right = nodes[4];
    nodes[2].Right = nodes[3];
    bt = new() { Root = nodes[0] };
    t = new TraversalBinaryTree<int>(bt);
    WriteLine($"BracketsPreOrder: {t.BracketsPreOrder()}");



    ReadLine();
    Clear();

    nodes = Enumerable.Range(0, 5)
                              .Select(e => new BinaryTreeNode<int>(e))
                              .ToArray();
    nodes[0].Left = nodes[1];
    nodes[0].Right = nodes[2];
    nodes[1].Left = nodes[4];
    nodes[2].Right = nodes[3];
    bt = new() { Root = nodes[0] };
    t = new TraversalBinaryTree<int>(bt);
    WriteLine($"BracketsPreOrder: {t.BracketsPreOrder()}");


    ReadLine();
    Clear();

    nodes = Enumerable.Range(0, 3)
                              .Select(e => new BinaryTreeNode<int>(e))
                              .ToArray();
    nodes[0].Left = nodes[1];
    nodes[0].Right = nodes[2];

    bt = new() { Root = nodes[0] };
    t = new TraversalBinaryTree<int>(bt);
    WriteLine($"BracketsPreOrder: {t.BracketsPreOrder()}");



    ReadLine();
    Clear();

    nodes = Enumerable.Range(0, 3)
                              .Select(e => new BinaryTreeNode<int>(e))
                              .ToArray();
    nodes[0].Left = nodes[1];
    nodes[1].Left = nodes[2];
    bt = new() { Root = nodes[0] };
    t = new TraversalBinaryTree<int>(bt);
    WriteLine($"BracketsPreOrder: {t.BracketsPreOrder()}");

    ReadLine();
    Clear();

    nodes = Enumerable.Range(0, 3)
                              .Select(e => new BinaryTreeNode<int>(e))
                              .ToArray();
    nodes[0].Right = nodes[1];
    nodes[1].Right = nodes[2];
    bt = new() { Root = nodes[0] };
    t = new TraversalBinaryTree<int>(bt);
    WriteLine($"BracketsPreOrder: {t.BracketsPreOrder()}");



    #endregion
  }
}