using System.Data;
using DiscordRPC;

var client = new DiscordRpcClient("1552652487570358283");

client.Initialize();

client.SetPresence(new RichPresence()
    {
        Details = "DaVinci Resolve",
        State = "Editing",
    }
);

Console.WriteLine("Discord Rich Presence connected!");
Console.ReadKey();
Console.ReadKey();