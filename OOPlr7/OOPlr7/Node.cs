namespace OOPlr7
{
    class Node
    {
        short data;
        Node? next;
        public Node(short data)
        {
            this.data = data;
            next = null;
        }
        public short Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node? Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
