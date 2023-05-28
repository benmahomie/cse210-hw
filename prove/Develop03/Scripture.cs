public class Scripture {

    private Reference _reference;
    private Word _word;
    private int _wordsLeft = 1; //default is one so program doesn't immediately end from <= 0 comaprison

    public Scripture(Reference reference, Word words) {
        _reference = reference;
        _word = words;
    }

    public void PresentScripture() {
        Console.Clear();
        if (_wordsLeft <= 0) {
            Console.WriteLine(_reference.RenderReference());
            _word.RenderWords();
            Console.WriteLine();
            Console.WriteLine("All lines are blank!");
            Console.Write("Press Enter to move on, or type 'restart' to restart: ");
            var restartOrQuit = Console.ReadLine();

            if (restartOrQuit == "restart") {
                _word.Restart();
                _wordsLeft = 1;
                PresentScripture();
            }
        }

        else {
            // Print reference
            Console.WriteLine(_reference.RenderReference());
            // Print modified scripture verse word by word, return true or false for isAllBlanks
            _word.RenderWords();
            Console.Write("Press Enter to continue, or type 'quit': ");
            var enterOrQuit = Console.ReadLine();

            if (enterOrQuit == "quit") {
                Console.WriteLine("Quitting...");
                Environment.Exit(0);
            }
            else {
                _wordsLeft = _word.HideWords(3);
                PresentScripture();
            }
        }
    }
}