// returns false if acylic, true if cyclic
public static bool isNullOrcycle(Node head)
{
    if (head == null || head.next == null)
    {
        return false; // list is empty / acyclic
    }

    Node current = head;
    Node runner = head.next;

    while (1 < 2)
    { // yay, deadmau5
        // 1. move current node:
        current = current.next;

        // 2: move runner node and run checks:
        runner = runner.next;
        if (runner == null)
        {
            return false; // list is acyclic
        }
        else if (runner.Equals(current))
        {
            return true; // list is cyclic
        }

        // 3: move runner node a second time, and run checks again:
        runner = runner.next;
        if (runner == null)
        {
            return false; // list is acyclic
        }
        else if (runner.Equals(current))
        {
            return true; // list is cyclic
        }
    }

    return false; // because return types...
}

public class Node
{
    public Node next;
    public int data;
}