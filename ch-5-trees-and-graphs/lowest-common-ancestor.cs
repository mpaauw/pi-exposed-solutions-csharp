public static Node lowestCommonAncestor(Node root, Node a, Node b)
{
    Node min = (a.data < b.data) ? a : b;
    Node max = (a.data > b.data) ? a : b;
    return findAncestor(root, min, max);
}

private static Node findAncestor(Node current, Node min, Node max)
{
    if (min.data < current.data && max.data < current.data)
    {
        return findAncestor(current.left, min, max);
    }
    else if (min.data > current.data && max.data > current.data)
    {
        return findAncestor(current.right, min, max);
    }
    else
    {
        return current;
    }
}

public class Node
{
    public Node left;
    public Node right;
    public int data;
}