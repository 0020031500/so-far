string line;
string filename = Console.ReadLine();
int lineNumber = int.Parse(Console.ReadLine());
string word = Console.ReadLine();
try
{
    using (StreamReader reader = new StreamReader($"C:\\Users\\0020031500\\OneDrive - Cheshire College South & West\\Desktop\\{filename.Replace(".txt", "")}.txt"))
    {
        int currentLineNumber = 0;
        while (!reader.EndOfStream)
        {
            if (lineNumber + 1 != currentLineNumber) return;
            line = reader.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch
{
    Console.WriteLine("Could not find that file!");
}
