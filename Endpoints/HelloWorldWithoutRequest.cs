using FastEndpoints;

public class HelloWorldWithoutRequest : EndpointWithoutRequest
{
    public override void Configure()
    {
        Verbs(Http.GET);
        Routes("/");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken cancellationToken) 
    {
        await SendAsync(new {
            message = "fala jacob"
        }, cancellation: cancellationToken);
    }
}