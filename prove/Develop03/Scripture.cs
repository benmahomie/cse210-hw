public class Scripture {

    private Reference _reference;
    private string[] _textAsList;
    private List<int> _hiddenIndex = new List<int>();
    private Random _random = new Random();

    public Scripture(Reference reference, string text) {
        _reference = reference;
        _textAsList = text.Split(' ');
        for (int i = 0; i < _textAsList.Length; i++) {
            _hiddenIndex.Add(i);
        }
    }

    private int GetRandomIndex(string[] textList) {
        int randomIndex = _random.Next(0, textList.Length);
        return randomIndex;
    }

    private void HideWords(int wordNum) {
        for (int i = 0; i < wordNum; i++) {
            int randomIndex = GetRandomIndex(_hiddenIndex);
            _textAsList[randomIndex] = "_";
        }
        if (_hiddenIndex.Length != _textAsList.Length) {
            PresentScripture();
        }
        else {
            Console.WriteLine("All lines blank!");
        }
    }

    public void PresentScripture() {
        Console.Clear();
        Console.WriteLine($"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetVerse()}");
        foreach (string word in _textAsList) {
            Console.Write($"{word} ");
        };

        Console.Write("Press Enter to continue, or type 'quit': ");
        var enterOrQuit = Console.ReadLine();

        if (enterOrQuit == "quit") {
            Console.WriteLine("Quitting...");
            Environment.Exit(0);
        }
        else {
            HideWords(5);
        }
    }
    
}