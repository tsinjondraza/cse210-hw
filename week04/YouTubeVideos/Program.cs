using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new("Ian", "Nice video");
        Comment comment2 = new("Lewis", "You guys are the best");
        Comment comment3 = new("Luke", "Bad video, too much AI in it. Internet don't lack ignorants!!!");
        Comment comment4 = new("Najoro", "WOW, WOW, wow");
        Comment comment5 = new("Dalix", "Watched it five times, can't stop, very addictive");
        Comment comment6 = new("Lucia", "The best...");
        Comment comment7 = new("Villy", "Keep it up!");
        Comment comment8 = new("Sylvia", "Liked it, need more of these!");
        Comment comment9 = new("JohnLove", "Very instructive, learnt many nice things");
        List<Comment> salalaComments = new List<Comment>
        {
            comment1,
            comment5,
            comment9,
            comment7
        };
        List<Comment> billyComments = new List<Comment>
        {
            comment3,
            comment6,
            comment9
        };
        List<Comment> ambondronaComments = new List<Comment>
        {
            comment2,
            comment4,
            comment1,
            comment5
        };

        List<Video> videoList = new List<Video>();
        Video video1 = new("Salala", "Ry Lanitra mangamanga", 240, salalaComments);
        Video video2 = new("Billy", "Don't let the sun go down on me", 300, billyComments);
        Video video3 = new("Ambondrona", "Tsy adala aho", 210, ambondronaComments);
        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);

        foreach (Video video in videoList)
        {
            Console.WriteLine(video.DisplayVideoDetails());
            Console.WriteLine($"Number of comments: {video.GiveCommentsNumber()}");
            List<string> allComments = video.DisplayComments();
            foreach (string feedback in allComments)
            {
                Console.WriteLine(feedback);
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}