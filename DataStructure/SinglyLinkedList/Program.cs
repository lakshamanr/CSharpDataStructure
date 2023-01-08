
public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int aintData)
    {
        this.Data = aintData;
        this.Next = null;
    }
}

public class Program
{
    private static Node Head { get; set; }
    private static bool  lblnCanWeBreakTheList = true;
    private static int lintInsertionPosition = 0;
    public static int intData = 0;

    public static void Main(string[] args)
    {
        Console.WriteLine("\n\n \t\t\t Welcome to Linked List");

        while (lblnCanWeBreakTheList)
        {
            Console.WriteLine("\n \t **Choose Element at Position**");

            Console.WriteLine("\n \t 1.Insert the Element at Position First");
            Console.WriteLine("\n \t 2.Insert the Element at Position Middle");
            Console.WriteLine("\n \t 3.Insert the Element at Position Last");
            Console.WriteLine("\n \t 4.Insert the Element at Position Nth");
            Console.WriteLine("\n \t 5.Delete the Element at Position First");
            Console.WriteLine("\n \t 6.Delete the Element at Position Middle");
            Console.WriteLine("\n \t 7.Delete the Element at Position Last");
            Console.WriteLine("\n \t 8.Delete the Element at Position Nth");
            Console.WriteLine("\n \t 9.Traverse  the list");
            Console.WriteLine("\n \t 10.Exist from the program");

            lintInsertionPosition = Convert.ToInt32(Console.ReadLine());
          
            switch (lintInsertionPosition)
            {
                case 1:
                {
                     Console.WriteLine("\n \t Enter Node Data");
                     intData = Convert.ToInt32(Console.ReadLine()); 
                     AddFirstNode(intData);
                }
                    break;
                case 3:
                {
                    Console.WriteLine("\n \t Enter Node Data");
                    intData = Convert.ToInt32(Console.ReadLine());
                    AddNodeAtLast(intData);
                }
                    break;
                case 9:
                {
                    IterateNodes();
                }
                    break;

                case 10:
                {
                    lblnCanWeBreakTheList = false;
                }
                    break;
            }
        }


    }

    public static void IterateNodes()
    {
        Node Current = Head;
        if (Current==null)
        {
            Console.WriteLine("There is nothing to iterate");
        }
        Console.WriteLine("\n\n******************* Node date ***************\n");

        do
        {
            Console.Write(Current.Data + "\t");
            Current = Current.Next;
        } while (Current.Next != null);

        Console.WriteLine("\n\n******************* Node date ***************");
    }

    public static void AddFirstNode(int aintData)
    {
        if (Head==null)
        {
            Head = new Node(aintData);
            return;
        }

        //Create node
        Node CurrentNode = new Node(aintData);

        //Append Head to current note
        CurrentNode.Next = Head;

        //Exchange current to head
        Head = CurrentNode;


    }

    public static void AddNodeAtLast(int aintData)
    {

        if (Head == null)
        {
            AddFirstNode(aintData);
            return;
        }

        Node head = Head;

        while (head.Next != null)
        {
            head = head.Next;
        }

        head.Next = new Node(aintData);
    }

    public static void AddNodeAtMiddle(int aintData)
    {

    }

    public static void AddbNodeAtNth(int aintData)
    {
    }

    public static void DeleteFirstNode()
    {
    }

    public static void DeleteNodeAtLast()
    {
    }

    public static void DeleteNodeAtMiddle()
    {
    }

    public static void DeleteNodeAtNthNode()
    {
    }

}