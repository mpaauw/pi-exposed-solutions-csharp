public static Node binaryTreeToHeap(Node root)
{
    int treeSize = traverse(root, null, 0);
    Node[] nodeArr = new Node[treeSize];
    traverse(root, nodeArr, 0);
    Array.Sort(nodeArr, delegate (Node x, Node y) { return x.data.CompareTo(y.data); });
    for (int i = 0; i < nodeArr.Length; i++) // heapify, simply reorganizing the node data within the existing tree structure
    {
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        nodeArr[i].left = ((left >= nodeArr.Length) ? null : nodeArr[left]);
        nodeArr[i].right = ((right >= nodeArr.Length) ? null : nodeArr[right]);
    }
    return nodeArr[0];
}

public static int traverse(Node node, Node[] arr, int iter)
{
    if (node == null)
    {
        return iter;
    }
    else if (arr != null)
    {
            arr[iter] = node;
    }
    iter++;
    iter = traverse(node.left, arr, iter);
    iter = traverse(node.right, arr, iter);
    return iter;
}

public class Node
{
    public Node left;
    public Node right;
    public int data;
}