using System;
using System.IO;
public class FileManager

{

    public static void SaveToFile(List<Video> videos)
    {

        string videoFile = "video.txt";
        string CommentFile = "comment.txt";
        using (StreamWriter outputVideo = new StreamWriter(videoFile))
        {

            using (StreamWriter outputComment = new StreamWriter(CommentFile))
            {

                for (int i = 0; i < videos.Count; i++)
                {
                    Video entry = videos[i];

                    string line = entry.GetId() + "|" + entry.GetTitle() + "|" + entry.GetAuthor() + "|" + entry.GetLength();
                    outputVideo.WriteLine(line);

                    List<Comment> comments = entry.GetComments();
                    for (int x = 0; x < comments.Count; x++)
                    {
                        Comment comment = comments[x];
                        string lineComment = comment.GetVideo() + "|" + comment.GetName() + "|" + comment.GetText();
                        outputComment.WriteLine(lineComment);
                    }
                }
            }
        }
    }




    public static List<Video> LoadFromFile()
    {
        string videoFile = "video.txt";
        string commentFile = "comment.txt";

        string[] lines = System.IO.File.ReadAllLines(videoFile);
        string[] linesComments = System.IO.File.ReadAllLines(commentFile);

        List<Video> list = new List<Video>();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string id = parts[0];
            Video entry = new Video(id, parts[1], parts[2], int.Parse(parts[3]));

            List<Comment> comments = new List<Comment>();

            foreach (string lineComment in linesComments)
            {
                string[] partsComment = lineComment.Split("|");
                string videoId = partsComment[0];
                if (videoId == id)
                {
                    comments.Add(new Comment(videoId, partsComment[1], partsComment[2]));
                }
            }

            entry.SetComments(comments);
            list.Add(entry);
        }

        return list;
    }

}