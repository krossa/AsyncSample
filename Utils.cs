public static class Utils
{
    public static void Dump(this object obj, bool addThreadId = true, ConsoleColor? color = null)
    {
        var tid = Thread.CurrentThread.ManagedThreadId;
        color ??= tid == 1 ? ConsoleColor.Red : ConsoleColor.Yellow;
        var msg = addThreadId ? $"Thread_Id({tid}) {obj}" : obj;


        Console.ForegroundColor = color.Value;
        Console.WriteLine(msg);
        Console.ForegroundColor = default;
    }
}