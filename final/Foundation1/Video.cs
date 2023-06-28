public class Video {
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _commentList = new List<Comment>();

    public Video (string title, string author, int lengthInSeconds) {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public void MakeComment(string commenter, string commentText) {
        Comment comment = new Comment(commenter, commentText);
        _commentList.Add(comment);
    }

    public void PrintAllComments() {
        Console.WriteLine("=============================================");
        Console.WriteLine($"\n\"{_title}\" by {_author} ({_lengthInSeconds} seconds):\n");
        for (int i = 0; i < _commentList.Count; i++) {
            _commentList[i].PrintComment();
            Console.WriteLine();
        }
        Console.WriteLine("=============================================");
    }
}