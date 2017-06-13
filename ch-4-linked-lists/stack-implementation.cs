public class Stack<T>
{
    private Node<T> top;
    private int size;

    public Stack(T top)
    {
        this.top = new Node<T>(top);
        this.size++;
    }

    public void push(T value)
    {
        if (this.size < 1)
        {
            this.top = new Node<T>(value);
            this.size++;
        }
        else
        {
            Node<T> newTop = new Node<T>(value);
            newTop.setNext(this.top);
            this.top = newTop;
            this.size++;
        }
    }

    public T peek()
    {
        if(this.size > 0)
        {
            return this.top.getData();
        }
        return default(T);
    }

    public T pop()
    {
        if(this.size > 0)
        {
            Node<T> oldTop = this.top;
            this.top = this.top.getNext();
            this.size--;
            return oldTop.getData();
        }
        return default(T);
    }

    public int getSize()
    {
        return this.size;
    }
}

public class Node<T>
{

    public Node(T data)
    {
        this.data = data;
    }

    private T data;

    private Node<T> next;

    public T getData()
    {
        return this.data;
    }

    public void setData(T data)
    {
        this.data = data;
    }

    public Node<T> getNext()
    {
        return this.next;
    }

    public void setNext(Node<T> next)
    {
        this.next = next;
    }

}