using Model;
using Request;
using Response;

using FastEndpoints;

namespace Mapper;

public class HelloWorldMap : Mapper<HelloWorldRequest, HelloWorldResponse, HelloWorldModel>
{
    public override HelloWorldModel ToEntity(HelloWorldRequest request) => new()
    {
        Name = request.Name,
    };

    public override HelloWorldResponse FromEntity(HelloWorldModel model) => new()
    {
        Name = model.Name,
        Today = DateTime.UtcNow
    };
}