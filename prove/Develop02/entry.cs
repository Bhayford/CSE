using System;

class Entry
{
    public DateTime _date;
    public string[] _prompts = {"What was your goal for the day? >", 
        "How did you start your day? >", "What are you grateful for today?", 
        "What made you feel Happy today?", "What are some lessons you learnt today?"};
    public string _message = "";

    public void Write()
    {
        _date = DateTime.Now;
        for (int i = 0; i < _prompts.Length; i++)
        {
            Console.WriteLine(_prompts[i]);
            _message += Console.ReadLine() + "\n";
        }
    }

    public override string ToString()
    {
        string output = "Date: " + _date + "\n";
        for (int i = 0; i < _prompts.Length; i++)
        {
            output += _prompts[i] + "\n" + _message.Split('\n')[i] + "\n";
        }
        return output;
    }
}