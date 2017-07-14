public static int getTreeHeight(Node root)
{
    return recurseHeight(root, 0);
}

private static int recurseHeight(Node root, int height)
{
    if (root == null)
    {
        return height;
    }
    return 1 + Math.Max(recurseHeight(root.left, height), recurseHeight(root.right, height));
}

public class Node
{
    public Node left;
    public Node right;
    public int value;
}