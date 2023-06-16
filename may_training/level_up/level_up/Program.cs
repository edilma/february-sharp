// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

object[] stuff = { "hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk" };
string answer = FindNeedle(stuff);

Console.WriteLine(answer);


 static string FindNeedle(object[] haystack)
{
   int position = Array.IndexOf(haystack, "needle");
    return $"found the needle at position {position}";

}
