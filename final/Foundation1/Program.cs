using System;

namespace YouTube
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();
            Video video1 = new Video("Dogs playing with owners", "Diane Smith", 120);
            video1.AddComment("Dog Lover", "This is so cute!");
            video1.AddComment("HeatherJ", "So stinking cute!");
            video1.AddComment("Diane Smith", "I know, right?");
            videos.Add(video1);

            
            Video video2 = new Video("Cats attacking the new puppy", "Sierra Jewett", 180);
            video2.AddComment("Cat Lover", "Cats rule, dogs drool!");
            video2.AddComment("HeatherJ", "So much fun!");
            video2.AddComment("Sierra Jewett", "They won't do that for too long, right? ");
            videos.Add(video2);

            
            Video video3 = new Video("How to clean your house", "Clean Freak", 300);
            video3.AddComment("anonymous", "This is stupid, waste of time.");
            video3.AddComment("anonymous", "Don't be so negative, these are great tips! ");
            video3.AddComment("Clean Freak", "Do what works for you! ");
            videos.Add(video3);

            
            Video video4 = new Video("How to train your dog to stop whinning.", "Dennis Jewett", 600);
            video4.AddComment("Dog Lover", "I love step #3, I will try that, thanks!");
            video4.AddComment("Dennis Jewett", "Yes it was a game changer for us!");
            video4.AddComment("Dog Lover", "Crossing Fingers!");
            videos.Add(video4);

            foreach (var video in videos)
            {
                video.DisplayVideoInfo();
            }
        }
           
    }
}