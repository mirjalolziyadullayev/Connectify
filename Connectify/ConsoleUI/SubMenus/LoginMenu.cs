using Connectify.Interfaces;
using Connectify.Services;
using Spectre.Console;

namespace Connectify.ConsoleUI.SubMenus;

public class LoginMenu
{
    UserService userService;
    public LoginMenu(UserService userService)
    {
        this.userService = userService;
    }
    public async Task Login()
    {
        Console.Clear();

        var firstname = AnsiConsole.Ask<string>("Enter your [green]FirtsName[/]:");
        var lastname = AnsiConsole.Ask<string>("Enter your [green]LastName[/]:");

        var user

        var table = new Table();

        table.AddColumn("Created Music");

        table.AddRow($"[green]MusicID[/]: {newMusic.Id}");
        table.AddRow($"[green]Music's Name[/]: {newMusic.Name}");
        table.AddRow($"[green]Music's Author[/]: {newMusic.Author}");
        table.AddRow($"[green]Music's Genre[/]: {newMusic.Genre}");

        AnsiConsole.Write(table);

        break;
    }
}
