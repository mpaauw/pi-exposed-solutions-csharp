public int findMthToLast(Node root, int m)
{
    Node current = root;
    for(int i = 0; i < m; i++) {
        if(current.next != null) {
            current = current.next;
        }
        else {
            return -1; // unable to satisfy mth-to-last condition.
        }
    }

    Node mBehind = root;
    while(current.next != null) {
        current = current.next;
        mBehind = mBehind.next;
    }

    return mBehind.data;
}

public class Node
{
    public int data;
    public Node next;
}