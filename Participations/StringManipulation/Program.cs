string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

Console.WriteLine(sentence);


Console.WriteLine("What word would you like to change?");
string lookUpWord = Console.ReadLine();

Console.WriteLine($"What would you like to change {lookUpWord} to? >>");
string changeWord = Console.ReadLine();


if (sentence.Contains(lookUpWord) == true)
{
    // change word and output new sentence
    Console.WriteLine("Found word");
    string correctedSentence = sentence.Replace(lookUpWord, changeWord);
    Console.WriteLine(correctedSentence);
}
else
{
    Console.WriteLine($"Sorry, I could not find your word {lookUpWord}.");
    //string reverseWord = lookUpWord.Reverse().ToString();

    //0 1 2 3 4 5  6
    //b a n a n a

    for (int i = lookUpWord.Length - 1; i >= 0; i--)
    {
        Console.Write(lookUpWord[i]);
    }
    Console.WriteLine();

}