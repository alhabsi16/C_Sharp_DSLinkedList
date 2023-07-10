namespace C_Sharp_DSLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Insert(10);
            linkedList.Insert(20);
            linkedList.Insert(30);
            linkedList.Insert(40);
           // linkedList.Display();

            //Console.WriteLine();
            //Console.WriteLine("Display after Deleting");
            //linkedList.Delete(40);
            //linkedList.Display();

            //Task: Add functionality to add item anywhere, given a position
          //  Console.WriteLine();
          //  Console.WriteLine("Display after add position ");
            linkedList.insertNewNode(50,6);
            linkedList.Display();

            //Console.WriteLine();
            //Console.WriteLine("Display after  ");
           Console.WriteLine(linkedList.findData(40));
        }
    }
}