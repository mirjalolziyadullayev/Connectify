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

        reenter:
        var id = AnsiConsole.Ask<int>("Enter your [green]ID[/]:");

        var user = userService.Get(id);

        if (user != null)
        {
            AnsiConsole.WriteLine("User is not found");
            goto reenter;
        }
        else
        {

        }   
    }
}
