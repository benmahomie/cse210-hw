public class Reference {

    private List<string> _books = new List<string>();
    private List<int> _chapters = new List<int>();
    private List<int> _verse = new List<int>();
    private List<int> _endVerse = new List<int>();

    public Reference(string book, int chapter, int verse) {
        _books.Add(book);
        _chapters.Add(chapter);
        _verse.Add(verse);        
    }

    public Reference(string book, int chapter, int verse, int endVerse) {
        _books.Add(book);
        _chapters.Add(chapter);
        _verse.Add(verse);
        _endVerse.Add(endVerse);        
    }

    public string GetBook(string entry) {
        return entry;
    }

    public int GetChapter(int entry) {
        return entry;
    }

    public string GetVerse(string entry) {
        return entry;
    }

}