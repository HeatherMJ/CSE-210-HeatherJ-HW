using System;
using System.Transactions;
namespace YouTube
{
    public class Video
    //making this private and defining this as a get so it is read only
    {
        private string _title;
        private string _author;
        private int _lengthInSeconds;
        private List<Comment> _comments;
        public Video(string title, string author, int lengthInSeconds)
    {
        _title = title; 
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }
    public string Title {get{return _title;}}
    public string Author {get{return _author;}}
    public int LengthInSeconds {get{return _lengthInSeconds;}}
    
    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name,text);
        _comments.Add(comment);
    }
    public int GetCommentAmount()
{
    return _comments.Count;
}
    public void DisplayVideoInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Length (sec): " + LengthInSeconds);
            Console.WriteLine("Comment Amount: " + GetCommentAmount());
            Console.WriteLine("Comments:");
            foreach (var comment in _comments)
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
    
}