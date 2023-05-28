public class Word {
    private List<string> _textAsListOriginal;
    private List<string> _textAsList;
    private List<int> _possibleIndices;
    private int _wordsHidden = 0;
    private Random _random = new Random();

    public Word(string text) {
        string[] words = text.Split(' ');
        _textAsListOriginal = new List<string>(words);
        _textAsList = _textAsListOriginal.ToList();
        _possibleIndices = Enumerable.Range(0, _textAsListOriginal.Count()).ToList();
    }
    private string GetRandomWord(int randomIndex) {
        string randomWord = _textAsList[randomIndex];
        return randomWord;
    }
    private int GetRandomIndex() {
        int index = _random.Next(0, _possibleIndices.Count());
        int randomIndex = _possibleIndices[index];
        _possibleIndices.RemoveAt(index);
        return randomIndex;
    }

    public int HideWords(int wordNum) {
        if ((_textAsList.Count() - _wordsHidden) < wordNum) {
            wordNum = _textAsList.Count() - _wordsHidden;
        }
        for (int i = 0; i < wordNum; i++) {
            int randomIndex = GetRandomIndex();
            string randomWord = GetRandomWord(randomIndex);
            string blankedWord = "";

            for (int a = 0; a < randomWord.Length; a++) {
                blankedWord += "_";
            }

            _textAsList[randomIndex] = blankedWord;
        }
        _wordsHidden += wordNum;
        return _textAsList.Count() - _wordsHidden;
    }

    public void RenderWords() {
        foreach (string word in _textAsList) {
            Console.Write($"{word} ");
        }
    }

    public void Restart() {
        _wordsHidden = 0;
        _textAsList = _textAsListOriginal.ToList();
        _possibleIndices = Enumerable.Range(0, _textAsListOriginal.Count()).ToList();
    }
}