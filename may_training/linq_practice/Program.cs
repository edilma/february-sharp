// See https://aka.ms/new-console-template for more information
var colors = new List<string> {"green", "Blush","Yellow","Red","Orange",
"Burgundy","Purple","White"};

var p = colors.Where(x => x.StartsWith("W)"));
Console.WriteLine(p);
