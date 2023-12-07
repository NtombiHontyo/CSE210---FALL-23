using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment = new Comment();
        comment._name = "Ntombi";
        comment._text = "I love this video.";
        Comment comment1 = new Comment();
        comment1._name = "Aduma";
        comment1._text = "This is wonderful";
        Comment comment2 = new Comment();
        comment2._name = "Masande";
        comment2._text = "This is very helpful";

        Video video = new Video();
        video._title = "The Title";
        video._author = "Tali";
        video._length = "20 Seconds";
        video._comments.Add(comment);
        video._comments.Add(comment1);
        video._comments.Add(comment2);

      

         Comment comment4 = new Comment();
        comment4._name = "Wendy";
        comment4._text = "I love love this video.";
        Comment comment5 = new Comment();
        comment5._name = "Mazozo";
        comment5._text = "This is truly wonderful";
        Comment comment6 = new Comment();
        comment6._name = "Anelisa";
        comment6._text = "This is very useful";

        Video video1 = new Video();
        video1._title = "The Real Title";
        video1._author = "Mviko";
        video1._length = "60 Seconds";
        video1._comments.Add(comment4);
        video1._comments.Add(comment5);
        video1._comments.Add(comment6);

        

        Comment comment7 = new Comment();
        comment7._name = "Thulani";
        comment7._text = "I dont like this video.";
        Comment comment8 = new Comment();
        comment8._name = "Kitty";
        comment8._text = "This is Bland";
        Comment comment9 = new Comment();
        comment9._name = "Bruno";
        comment9._text = "This is the best video I have seen thus far";
        Comment comment10 = new Comment();
        comment10._name = "Rex";
        comment10._text = "It is watchable";


        Video video3 = new Video();
        video3._title = "The Real Real Title";
        video3._author = "Lwandle";
        video3._length = "120 Seconds";
        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);
        video3._comments.Add(comment10);

        List<Video> videos = new List<Video>();
        videos.Add(video);
        videos.Add(video1);
        videos.Add(video3);

        foreach (Video videoo in videos)
        {
            Console.WriteLine();
            videoo.DisplayVideoDetails();
        }

    }
}