Application app = new Application();
app.CreateUI();

// invoker class in command pattern
public class Application
{

    public Car activeCar;
    EnterInfoCommand enterInfo = new EnterInfoCommand();
    ShowCommand show = new ShowCommand();

    public void CreateUI()
    {
        read:
        Console.WriteLine("Choose a command to execute:\n" +
                  "1. Show Car Info\n" +
                  "2. Enter Car Info\n" +
                  "3. Exit\n");
        string? option = Console.ReadLine();
        switch (option)
        {
            case "1":
                show.Execute();
                goto read;
            case "2":
                enterInfo.Execute();
                goto read;
            case "3":
                ExitCommand exit = new ExitCommand();
                exit.Execute();
                goto read;
            default:
                Console.WriteLine("Wrong input");
                goto read;

        }
    }
}