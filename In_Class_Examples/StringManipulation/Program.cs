//             012345678910
string name = "hENRY JAMES";
//H.J.
string name2 = "Clark Kent";
//C.K.

string lowerName = name.ToLower();

Console.WriteLine(lowerName);

string firstLetterOfFirstName = name.Substring(0, 1).ToUpper();
//using index notation
//firstLetterOfFirstName = name[0].ToString();
//alternative way
//firstLetterOfFirstName = firstLetterOfFirstName.ToUpper();
int indexOfSpace = name.IndexOf(' ');
string firstLetterOfSecondName = name.Substring(indexOfSpace + 1, 1);

string initials = $"{firstLetterOfFirstName}.{firstLetterOfSecondName}.";
Console.WriteLine(initials);