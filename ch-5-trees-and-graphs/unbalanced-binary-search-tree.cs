// This implementation is more complex than that offered by the book, and assumes that the tree's imbalance must be checked until it has been solved.
public static Node balanceBST(Node root)
{
    int leftHeight = getHeight(root.left, 1);
    int rightHeight = getHeight(root.right, 1);
    while ((leftHeight - rightHeight) > 1)
    {
        root = balance(root);
        leftHeight = getHeight(root.left, 1);
        rightHeight = getHeight(root.right, 1);
    }
    return root;
}

private static int getHeight(Node node, int height)
{
    if (node == null)
    {
        return height;
    }
    height += 1;
    return Math.Max(getHeight(node.left, height), getHeight(node.right, height));
}

private static Node balance(Node node)
{
    Node oldRightChild = node.left.right;
    Node oldRoot = node;
    node = node.left;
    node.right = oldRoot;
    node.right.left = oldRightChild;
    return node;
}

public class Node
{
    public Node left;
    public Node right;
    public int data;
}