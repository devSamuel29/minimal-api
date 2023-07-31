using Mapper;
using Request;
using Response;
using FastEndpoints;

public class HelloWorldWithRequest : Endpoint<
    HelloWorldRequest, 
    HelloWorldResponse, 
    HelloWorldMap
>
{
    public override void Configure()
    {
        Verbs(Http.GET);
        Routes("/{name}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(
        HelloWorldRequest request, 
        CancellationToken cancellationToken
    ) 
    {
        var helloWorldModel = Map.ToEntity(request);
        Response = Map.FromEntity(helloWorldModel);

        await SendAsync(Response, cancellation: cancellationToken);
    }
}