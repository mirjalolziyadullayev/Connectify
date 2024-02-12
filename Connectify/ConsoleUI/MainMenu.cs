using Connectify.ConsoleUI.SubMenus;
using Connectify.Services;
using Spectre.Console;

namespace Connectify.ConsoleUI;

public class MainMenu
{
    private UserService userService;
    private PostService postService;

    private LoginMenu loginMenu;
    public MainMenu()
    {
        this.userService = new UserService();
        this.postService = new PostService(userService);

        this.loginMenu = new LoginMenu(userService);
    }
    public async Task Display()
    {
        while (true)
        {
            var choise = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("[green]Connect[/][grey]ify[/]")
                    .PageSize(7)
                    .AddChoices(new[] {
                        "Register",
                        "Login\n",
                        "[red]Exit[/]"}));
            switch (choise)
            {
                case "Register":
                    Console.Clear();
                    
                    break;
                case "Login":
                    Console.Clear();
                    loginMenu.Login();
                    break;
                case "[red]Exit[/]":
                    Console.Clear();
                    return;
            }
        }
    }
}
