namespace Response;

public class HelloWorldResponse
{
    public string? Name { get; set;}

    public DateTime Today { get; set; } = DateTime.UtcNow;
}