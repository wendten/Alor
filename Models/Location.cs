namespace Alor.Web.Models;

public sealed class Location
{
    public required string Name { get; init; }
    public required string Region { get; init; }
    public required string Description { get; init; }
    public required string Type { get; init; }
    public required double X { get; init; }
    public required double Y { get; init; }
}
