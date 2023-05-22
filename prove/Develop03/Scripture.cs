public class Scripture {

    private List<string> _scriptureList = new List<string>();

    private Scripture(Reference reference, string text) {
    }

    public string HideWords(string entry) {
        foreach(char word in entry) {
            Console.WriteLine(word);
        }
        return entry;
    }

    public void RenderText() {

    }
    
}