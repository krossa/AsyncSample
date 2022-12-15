async Task ProcessAsync()
{
    "PROCESS initialize".Dump();
    var task = ExternalAsync();

    "PROCESS more work 1".Dump();
    var a = 0;
    for (int i = 0; i < 1_000_000; i++)
    {
        a += i;
    }
    "PROCESS more work 2".Dump();

    var result = await task;
    $"PROCESS finalize: {result}".Dump();
}

async Task<string> ExternalAsync()
{
    "External initialize".Dump();
    await Task.Delay(100);

    "External finalize".Dump();
    return "external result";
}


"Entry point".Dump(color: ConsoleColor.White);
await ProcessAsync();
