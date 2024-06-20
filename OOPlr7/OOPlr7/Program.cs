using OOPlr7;

class Program
{
    static void Main()
    {
        ////Add
        //SinglyLinkedList list = new SinglyLinkedList();
        //for (short i = 0; i < 10; i++)
        //{
        //    list.Add(i);
        //}
        //Console.Write("Your list of elements: ");
        //PrintList(list);

        ////GetBiggerElement
        //short value = 3;
        //Node? node = list.GetBiggerElement(value);
        //if (node != null)
        //    Console.WriteLine("First node bigger than " + value + ": " + node.Data);

        ////GetSumOfElementBiggerThanAverageValue
        //int sum = list.GetSumOfElementBiggerThanAverageValue();
        //Console.WriteLine("Sum of element bigger than average value: " + sum);

        ////GetListOfElementsSmallerThanAverageValue
        //SinglyLinkedList smallList = list.GetSmallerThanAverage();
        //Console.Write("List of elements smaller than average value in: ");
        //PrintList(smallList);

        ////DeleteNodesAfterMaxNode
        //list.DeleteAfterMax();
        //Console.Write("List after deletion of nodes after max node: ");
        //PrintList(list);

    }
    public static void PrintList(SinglyLinkedList list)
    {
        if (list.Head is null)
        {
            Console.WriteLine("List is empty");
            return;
        }
        Node currentNode = list.Head;
        Console.Write(currentNode.Data + " ");
        while (currentNode.Next is not null)
        {
            currentNode = currentNode.Next;
            Console.Write(currentNode.Data + " ");
        }
        Console.WriteLine();
    }
}