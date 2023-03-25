class TerminalManager
{
    public static Int32 GetMenuChoice()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Create Videos");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.WriteLine("What would you like to do?:");
        string read = Console.ReadLine();
        return Int32.Parse(read);
    }


    public static void DisplayVideos(List<Video> videos)
    {
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength());
            List<Comment> comments = video.GetComments();
            Console.WriteLine("Comments: ");
            foreach (Comment comment in comments)
            {
                Console.WriteLine("- Author: " + comment.GetName() + ", Comment: " + comment.GetText());
            }
        }
        Console.WriteLine("----------------------");
    }
}