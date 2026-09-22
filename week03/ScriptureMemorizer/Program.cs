using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference ("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture (reference, "Trust in the Lord with all your heart and lean not on your own understanding");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();

            Console.Write("Press Enter to hide words or type 'quit' to exit: ");
            
            string input = Console.ReadLine();

            if(input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}


class Reference
{
    private string book;
    private int chapter;
    private int  startVerse;
    private int endVerse;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = verse;
        this.endVerse = verse;
    }

    public Reference (string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (startVerse == endVerse)
        {
            return $"{book} {chapter} : {startVerse}";
        }
        return $"{book} {chapter} : {startVerse}- {endVerse}";
    }
}
class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    public string GetDisplayText()
    {
        if (isHidden)
        {
                return new string('_',text.Length);
        }

        return text;
    }
    
}
 class Scripture
{
    private Reference reference;
    
    private Word[] words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        string[] wordlist = text.Split(" ");
        words =  new Word[wordlist.Length];
        
        for (int i = 0; i< wordlist.Length; i++)
        {
            words[i] = new Word(wordlist[i]);
        }
    }

    public string GetDisplayText()
    {
        string result = reference.GetDisplayText() + " ";

        foreach (Word word in words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result.Trim();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(words.Length);
            words[randomIndex].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }


}






















