using AlphabeticalOrder;

ConsolePersonalizator.ConsoleColorPrint(@"  __  __           __  __                 ____             
 |  \/  | __ _ ___|  \/  | ___  _ __ _ __|  _ \  _____   __
 | |\/| |/ _` |_  / |\/| |/ _ \| '__| '__| | | |/ _ \ \ / /
 | |  | | (_| |/ /| |  | | (_) | |  | |  | |_| |  __/\ V / 
 |_|  |_|\__,_/___|_|  |_|\___/|_|  |_|  |____/ \___| \_/  
                                                           
┌──────────────────────────────────────────────────────────┐
│    Welcome to AlphabeticalOrder! Type 'help' for         │
│    instructions or 'order' to start processing files     │
└──────────────────────────────────────────────────────────┘", ConsoleColor.DarkCyan);

while (true)
{
    Console.Write("▸ ");
    string input = (Console.ReadLine() ?? "").Trim().ToLower();
    if (input.Equals("exit"))
    {
        ConsolePersonalizator.ConsoleColorPrint("Thx for using AlphabeticalOrder CLI, bye bye :D", ConsoleColor.DarkGreen);
        return;
    }
    CommandProcesser.CommandExecuter(input);
}