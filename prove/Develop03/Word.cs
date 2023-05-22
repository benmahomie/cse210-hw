public class Word {

    List<string> _words = new List<string>();

    public Word(string words) {
        _words.Add(words);
    }

    public string Hide() {
        return "_ _ _ _";
    }

    public string Show() {
        return "word word word";
    }

    public string Hidden() {
        return "hiddenword hiddenword hiddenword";
    }

    public string GetRenderedText() {
        return "word word _ _ _ _ word";
    }
}