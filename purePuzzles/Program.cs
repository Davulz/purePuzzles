// See https://aka.ms/new-console-template for more information
var metoder = new Metoder();

Console.Write("Enter a line of text:");
var Text =Console.ReadLine().ToLower();

metoder.WordsLength( Text );
metoder.CheckVowels( Text );

Console.WriteLine($"Setningen er {metoder.Strlist.Length} ord lang.\nLengste ord er {metoder.WordLength} bokstaver langt, og er: {metoder.LongestWord}\nOrdet med flest vokaler har {metoder.NumberOfVowels}stk.");