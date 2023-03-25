
using System;

public class VideoGenerator
{


    public static List<Video> GetListVideo()
    {


        List<Video> videoList = new List<Video>();

        // video1
        List<Comment> comments = new List<Comment>();
        comments.Add(new Comment("1", "Cool", "Praise Jesus!"));
        comments.Add(new Comment("1", "Brandon Fedrick", "So excited for this!!!"));
        comments.Add(new Comment("1", "Ding Dong2023", "Amen"));
        Video video = new Video("1", "HE IS RISEN Listen to Christian Songs of Jesus Christ", "The Church of Jesus Christ of Latter-day Saints", 300);

        video.SetComments(comments);
        videoList.Add(video);

        // video2
        List<Comment> comments1 = new List<Comment>();
        comments1.Add(new Comment("2", "Noskal Borg", "Wonderful"));
        comments1.Add(new Comment("2", "V Smith", "miss my husband so much!  This popped up on my phone today. It brought tears to me."));
        comments1.Add(new Comment("2", "Dan Tera", "Gott er hört mich ❤ ich habe es erlebt! Betet er hört auch euch! Wir sind alle Kinder Gottes"));
        Video video1 = new Video("2", "Are You Really There?", "The Church of Jesus Christ of Latter-day Saints", 200);
        video1.SetComments(comments1);
        videoList.Add(video1);

        // video3
        List<Comment> comments2 = new List<Comment>();
        comments2.Add(new Comment("3", "Millenial Hymns", "Beautiful! My heart has turned in the last couple years. I didn't pay attention to all this refugee stuff. But now I know how important it is to help. This is beautiful. Thank you for making this."));
        comments2.Add(new Comment("3", "Jayson Wild", "Absolutely wonderful, it's so powerful seeing the love, kindness, and devotion of these people in serving with the gifts God has given them. I hope I can do the same!"));
        comments2.Add(new Comment("3", "Shantel", " remember helping my Dad to get together some furniture and such that we had for a refugee family in the area.  I wasn't too happy about giving up my Saturday after a busy work week, but I'm honestly glad to have been able to help him to help them, even if all I really contributed was some physical labor on my part 😁"));
        Video video2 = new Video("3", "Christlike Service to Refugees", "The Church of Jesus Christ of Latter-day Saints", 100);
        video2.SetComments(comments2);
        videoList.Add(video2);

        return videoList;
    }
}