namespace KnowledgeCheck_2;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many mugs do you want to add? ");
        var numberOfMugs = int.Parse(Console.ReadLine());

        var mugList = new List<MyMug>();
        for (int i = 0; i < numberOfMugs; i++)
        {
            Console.WriteLine("Enter the value for mug ");

            var myMug = new MyMug();

            Console.WriteLine("Name: ");
            myMug.Name = Console.ReadLine();

            Console.WriteLine("Color: ");
            myMug.Color = Console.ReadLine();

            Console.WriteLine("Description: ");
            myMug.Description = Console.ReadLine();


            mugList.Add(myMug);
        }

        Console.WriteLine("List of mugs:");
        foreach (var mug in mugList)

        {
            Console.WriteLine(mug);
        }
    }
}

