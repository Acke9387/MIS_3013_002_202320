

string[] entireBook = File.ReadAllLines("Greatest wonders of the world by Esther Singleton and Esther Singleton.txt");


foreach (string sentence in entireBook)
{
	Console.WriteLine(sentence); 
}

// For loop equivalent
for (int i = 0; i < entireBook.Length; i++)
{
	string sentence = entireBook[i];
	if (i % 10 == 0)
	{
		Console.WriteLine(sentence); 
	}
}