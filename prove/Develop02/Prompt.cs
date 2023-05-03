public class Prompt
{
    List<string> _usedPrompts = new List<string>();
    List<string> _prompts = new List<string>();

    public Prompt()
    {
        _prompts.Add("What was something exciting that happened today?");
        _prompts.Add("When were you most happy today?");
        _prompts.Add("What was the best smell you smelled today?");
        _prompts.Add("Describe the most enjoyable activity you did today.");
        _prompts.Add("How are you feeling right now?");
        _prompts.Add("Where did you go, or want to go, today?");
    }

    public string GetRandomPrompt()
    {
        // select a random integer in the range of the length of _prompts
        var random = new Random();
        int index = random.Next(_prompts.Count);

        // set a new variable equal to the string at a random index in _prompts
        string randomPrompt = _prompts[index];

        // remove chosen prompt from prompt list and add to used list
        _prompts.RemoveAt(index);
        _usedPrompts.Add(randomPrompt);

        return randomPrompt;
    }
}