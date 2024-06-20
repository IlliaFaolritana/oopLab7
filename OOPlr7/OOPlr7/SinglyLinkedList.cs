namespace OOPlr7
{
    class SinglyLinkedList
    {
        private Node? head;
        public SinglyLinkedList() 
        {
            head = null;
        }
        public Node? Head
        {
            get { return head; }
        }
        public void Add(short value)
        {
            if (head is null)
                head = new Node(value);
            else
            {
                if(head.Next is null)
                    head.Next = new Node(value);
                else
                {
                    Node tempNode = head.Next;
                    head.Next = new Node(value);
                    head.Next.Next = tempNode;
                }
            }
        }
        public Node? GetBiggerElement(short value)
        {
            if (head is null)
                return null;
            if(head.Data > value)
                return head;

            Node currentNode = head;
            while (currentNode.Next is not null)
            {
                currentNode = currentNode.Next;
                if(currentNode.Data > value)
                    return currentNode;
            }
            return null;
        }
        public int GetSumOfElementBiggerThanAverageValue()
        {
            int sum = 0;
            if(head is null)
                return sum;

            short averageValue = GetAverageValue();
            Node currentNode = head;

            if(currentNode.Data > averageValue)
                sum += currentNode.Data;

            while(currentNode.Next is not null)
            {
                currentNode = currentNode.Next;
                if(currentNode.Data > averageValue)
                    sum += currentNode.Data;
            }
            return sum;
        }
        public SinglyLinkedList GetSmallerThanAverage()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            if (head is null)
                return list;

            short averageValue = GetAverageValue();
            Node currentNode = head;

            if (currentNode.Data < averageValue)
                list.Add(currentNode.Data);

            while (currentNode.Next is not null)
            {
                currentNode = currentNode.Next;
                if (currentNode.Data < averageValue)
                    list.Add(currentNode.Data);
            }
            return list;
        }
        public void DeleteAfterMax()
        {
            Node? maxNode = GetMaxNode();
            if (maxNode is null)
                return;
            
            Node currentNode = head;
            if (currentNode == maxNode)
                if (currentNode.Next is not null)
                    currentNode.Next = null;
            else
            {
                while (currentNode.Next is not null)
                {
                    currentNode = currentNode.Next;
                    if(currentNode == maxNode)
                        if (currentNode.Next is not null)
                            currentNode.Next = null;
                }
            }
        }
        private short GetAverageValue()
        {
            if(head is null)
                return 0;

            Node currentNode = head;
            int value = currentNode.Data;
            int counter = 0;
            while (currentNode.Next is not null)
            {
                currentNode = currentNode.Next;
                value += currentNode.Data;
                counter++;
            }
            return (short)(value / counter);
        }
        private Node? GetMaxNode()
        {
            if (head is null)
                return head;
            Node currentNode = head;
            Node maxNode = currentNode;
            while (currentNode.Next is not null)
            {
                currentNode = currentNode.Next;
                if(currentNode.Data < maxNode.Data)
                    maxNode = currentNode;
            }
            return maxNode;
        }
    }
}
