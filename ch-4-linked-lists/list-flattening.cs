public static void flattenList(Node head, Node tail)
{
    Node current = head;

    while (current != null)
    {
        if (current.child != null)
        {
            append(current.child, ref tail); // ref used to retain new tail
        }
        current = current.next;
    }
}

public static void append(Node child, ref Node tail) // ref used to retain new tail
{
    tail.next = child;
    child.prev = tail; // handling double-link

    Node current;

    for (current = child; current.next != null; current = current.next){ } // proceed to new tail

    tail = current;

}

public class Node
{
    public Node next;
    public Node prev;
    public Node child;
    public int data;
}