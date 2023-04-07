using System;

internal static class Helper
{
    public static void DisplayTask(string taskNumber, string taskName)
    {
        global::System.Console.WriteLine($"Task {taskNumber}: {taskName}");
        global::System.Console.WriteLine(new String('-', $"Task {taskNumber}: {taskName}".Length));
    }

    public static void DisplayExample(string example, string output)
    {
        global::System.Console.WriteLine($"{example}");
        global::System.Console.WriteLine($"Example output: {output}");
        global::System.Console.Write($"program output: ");
    }
}
