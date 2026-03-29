
using UnitTesting02.Projects;

var issues = new List<Issue> {
    new Issue("Secretary laptop giving blue screen", Priority.High, Category.UnKnown, DateTime.Now),
                new Issue("Printer switch at office #104 is broken", Priority.Urgent, Category.Hardware, DateTime.Now),
                new Issue("Upgrade OS for Laptop 101 to windows 11", Priority.Medium, Category.Software, DateTime.Now),
                new Issue("Install Password manager application on Laptop 112", Priority.Low, Category.UnKnown, DateTime.Now),
                new Issue("Change HDMI Cable for Cafeteria TV", Priority.Low, Category.Hardware, DateTime.Now)
};
static void Print(List<Issue> issues)
{
    var defaultColor = Console.ForegroundColor;
    foreach(var issue in issues)
    {
        Console.ForegroundColor = issue.Priority switch { 
        Priority.Urgent=> ConsoleColor.Red,
        Priority.High=> ConsoleColor.DarkRed,
        Priority.Medium=> ConsoleColor.Yellow,
        Priority.Low=> ConsoleColor.DarkYellow,
         _ => ConsoleColor.Cyan
        };
        Console.WriteLine(issue);
        Console.ForegroundColor = defaultColor;
    }
    Console.WriteLine($"\n\nTotal Issues: [{issues.Count}]");
}