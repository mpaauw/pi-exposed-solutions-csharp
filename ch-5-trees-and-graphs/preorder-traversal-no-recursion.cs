public static void preorderTraversalIterative(Node node)
{
    Stack<Node> stack = new Stack<Node>();
    do
    {
        if(node.status.Equals("visited"))
        {
            if (stack.Count > 0)
            {
                node = stack.Pop();
            }
        }
        if (node.status.Equals("unvisited"))
        {
            System.Diagnostics.Debug.WriteLine(node.value);
            node.status = "visiting";
        }
        if (node.left != null && node.left.status.Equals("unvisited"))
        {
            stack.Push(node);
            node = node.left;
        }
        else if (node.right != null && node.right.status.Equals("unvisited"))
        {
            stack.Push(node);
            node = node.right;
        }
        else
        {
            node.status = "visited";              
        }
    } while (stack.Count > 0);
}

public class Node
{
    public Node left;
    public Node right;
    public string status = "unvisited";
    public int value;
}