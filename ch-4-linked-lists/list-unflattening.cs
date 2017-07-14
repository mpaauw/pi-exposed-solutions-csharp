// All that's going on in this algorithm is essentially 'severing' the links that were created (continuously appended to the tail of the list) in the previous problem, 'list-flattening'.
public static void unflattenList(Node head, Node tail) {
    divideAndConquer(ref head); // terminate links between child nodes and the flattened list.
    Node current;
    for(current = head; current.next != null; current = current.next){} // find the new (original) tail of the list.
    tail = current;
}

public static void divideAndConquer(ref Node childListHead) {
    Node current = childListHead;
    while(current != null) {
        if(current.child != null) { // terminate both the links from the child's previous pointer, and the child's previous node's next pointer.
            current.child.prev.next = null;
            current.child.prev = null;
            divideAndConquer(ref current.child);
        }
        current = current.next;
    }
}

public class Node
{
    public Node next;
    public Node prev;
    public Node child;
    public int data;
}