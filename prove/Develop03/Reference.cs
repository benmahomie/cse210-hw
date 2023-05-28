public class Reference {

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;

    public Reference(string book, int chapter, int verse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;        
    }

    public Reference(string book, int chapter, int verse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;        
    }

    private string GetBook() {
        return _book;
    }

    private int GetChapter() {
        return _chapter;
    }

    private string GetVerse() {
        if (_endVerse == 0) {
            return $"{_verse}";
        }
        else {
            return $"{_verse}-{_endVerse}";
        }
    }

    public string RenderReference() {
        return $"{GetBook()} {GetChapter()}:{GetVerse()}";
    }

}