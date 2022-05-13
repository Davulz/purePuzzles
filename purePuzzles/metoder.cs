using System;
using System.Linq;

public class Metoder
{
    public int WordLength { get; set; }
    public string LongestWord;
    private readonly char[] _separator;
    public string[] Strlist;
    public int NumberOfVowels { get; set; }


    public Metoder()
    {
        WordLength = 0;
        LongestWord = "";
        _separator = new char[] { ' ', '?', ',' };
        NumberOfVowels = 0;
    }

    public void WordsLength(string text)
    {
        Strlist = text.Split(_separator);

        foreach (var ord in Strlist)
        {
            if (ord.Length > WordLength)
            {
                WordLength = ord.Length;
                LongestWord = ord;
            }

            if (ord.Length != WordLength)
            {
                return;
            } 
            
            var wrdlist = LongestWord.Split(_separator);
                var kopi = false;
                foreach (var longWords in wrdlist)
                {
                    if (longWords == ord)
                    {
                        kopi = true;
                    }

                    if (!kopi)
                    {
                        LongestWord += " " + ord;
                    }
            }
        }
    }

    public void CheckVowels(string text)
    {
        Strlist = text.Split(_separator);
        var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' , 'æ', 'ø' , 'å' };


        foreach (var i in Strlist)
        {
            var vowelsCount = i.Count(c => vowels.Contains(c));
            if (vowelsCount > NumberOfVowels) NumberOfVowels = vowelsCount;
        }
    }




}

    
