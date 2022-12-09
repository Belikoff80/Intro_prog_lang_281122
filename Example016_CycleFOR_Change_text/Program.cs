//all backspace - replace with |
//lower letter k replace with upper K
//upper C - replace with lower c

string text = "-Я думаю, - сказал князь, улыбаясь, - что, " +
"вы бы взяли приступом согласие прусского короля?";
//pay attantion that:
// string s = "qwerty"
//             012345
//s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
string newText1 = Replace(newText, 'с', 'С');
Console.WriteLine(newText1);
Console.WriteLine();
string newText2 = Replace(newText1, 'к', 'К');
Console.WriteLine(newText2);