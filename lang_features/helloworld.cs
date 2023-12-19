public class HelloWorld
{
    private string Username;

    // constructor
    public HelloWorld(string username)
    {
        this.Username = username;
        Console.WriteLine($"Account has been created with username: {username}.");
    }

    // setters and getters
    public string Account
    {
        get { return $"ACC-{this.Username}"; }
        set { this.Username = value; }
    }
}
