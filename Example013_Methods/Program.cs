
// Types of Methods
//////////////////////////////////////////////////////
//1 type nothing input nothing output

void Method1()
{
    Console.WriteLine("Autor.....");
}
Method1();

//////////////////////////////////////////////////////
//2 type  nothing output but something input
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "some text for attempt");// msg: - can be added  in case we 
//want output directly mentioned arguments in cases few arguments in method

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
Method2_1("text for attempt 21", 4);

////////////////////////////////////////////////////
//3 type something output and nothing input

//!! pay attantion. it s needed to note what type of data method will be output

int Method3()
{
    return DateTime.Now.DayOfYear;
}
Console.WriteLine(Method3());

////////////////////////////////////////////////////////
//4 type something input and something output

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "fuck");
Console.WriteLine(res);