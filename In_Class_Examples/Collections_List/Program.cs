List<string> favoriteFruits = new List<string>();

favoriteFruits.Add("grapes");
favoriteFruits.Add("apple");
favoriteFruits.Add("orange");

Console.WriteLine("My Favorite fruits are ...");

//for (int i = 0; i < favoriteFruits.Count; i++)
//{
//	favoriteFruits[i] = favoriteFruits[i] + ".";
//	if (favoriteFruits[i].ToLower()[0] == 'a')
//	{
//		Console.WriteLine(favoriteFruits[i].ToUpper()); 
//	}
//}

foreach (string fruit in favoriteFruits)
{
    Console.WriteLine(fruit);
}