public static void preorderTraversal(Node root) {
    recurseTraversal(root);
}

private static void recurseTraversal(Node root) {
    if(root == null) {
        return;
    }
    Console.WriteLine(root.value);
    recurseTraversal(root.left);
    recurseTraversal(root.right);
}

public class Node {
    public Node left;
    public Node right;
    public int value;
}