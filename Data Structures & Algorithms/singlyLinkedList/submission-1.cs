// we will create a list node with a value and a next pointer
public class Node {
    public int Val;
    public Node Next;
    public Node(int val) {
        Val = val;
        Next = null;
    }
}
public class LinkedList {
    public Node Head;
    public Node Tail;
    public LinkedList() {
        Head = null;
        Tail = null;
    }

    public int Get(int index) {
        Node curr = Head;
        for (int i = 0; i < index; i++) {
            if (curr != null) {
                curr = curr.Next;
            }
        }
        if (curr != null) return curr.Val;
        return -1;
    }

    public void InsertHead(int val) {
        Node newNode = new Node(val);
        
        if (Head == null) {
            Head = newNode;
        } else {
            newNode.Next = Head;
            Head = newNode;
        }
        if (Tail == null) {
            Tail = Head;
        }
    }

    public void InsertTail(int val) {
        Node newNode = new Node(val);
        if (Tail == null) {
            Tail = newNode;
        } else {
            // Tail.Next will equal newNode instead of null
            // Tail = Tail.Next to make last element tail
            Tail.Next = newNode;
            Tail = Tail.Next;
        }

        if (Head == null) {
            Head = Tail;
        }
    }

    public bool Remove(int index) {
        if (Head == null) return false;
        if (index == 0){
         Head = Head.Next;
         if (Head == null) Tail = null;
            return true;
        }
        int i = 0;
        Node curr = Head;
        while (i < index -1 && curr != null)
        {
            i++;
            curr = curr.Next;
        }

        // Remove the node ahead of curr
        if (curr != null && curr.Next != null)
        {
            if (curr.Next == Tail)
            {
                Tail = curr;
            }
            curr.Next = curr.Next.Next;
            return true;
        } else {
            return false;
        }
    }

    public List<int> GetValues() {
        List<int> result = new List<int>();
        Node curr = Head;
        while (curr != null) {
            result.Add(curr.Val);
            curr = curr.Next;
        }
        return result;
    }
}