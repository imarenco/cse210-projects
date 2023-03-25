using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        List<Video> list = new List<Video>();

        while (!quit)
        {
            Int32 action = TerminalManager.GetMenuChoice();

            switch (action)
            {
                case 1:
                    // write
                    list = VideoGenerator.GetListVideo();
                    break;
                case 2:
                    // display
                    TerminalManager.DisplayVideos(list);
                    break;
                case 3:
                    // load
                    list = FileManager.LoadFromFile();
                    break;
                case 4:
                    // save
                    FileManager.SaveToFile(list);
                    break;
                case 5:
                default:
                    quit = true;
                    break;
            }
        }
    }



}