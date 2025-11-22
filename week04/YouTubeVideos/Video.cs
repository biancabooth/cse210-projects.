using System.Runtime.CompilerServices;

public class Video
{
private string _title;
private string _author;
private double _length;
private List<Comment> _comments = new List<Comment>();
public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();

    }
public string GetTitle()
    {
        return _title;
    }    
public void SetTitle(string title)
    {
        _title = title;
    }    
 public string GetAuthor()
    {
        return _author;
    }    
public void SetAuthor(string author)
    {
        _author = author;
    }   
    public double GetLength()
    {
        return _length;
    }    
public void SetTitle(double length)
    {
        _length = length;
    }   
public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }    
public int NumberOfComments()
    {
        int count = 0;
       foreach(Comment c in _comments)
        {  
            count++;
        } 
        return count;
    }    

public string DisplayText()
    {
        string _together = $"Title: {GetTitle()}, Author: {GetAuthor()}, Length of Video: {GetLength()} minutes.\n";
        _together += $"Comment Count:{NumberOfComments()}\n";
        foreach(Comment c in _comments)
        {
            _together += $"{c.DisplayComment()}\n";
        }
       
        return _together;
    }
}    
