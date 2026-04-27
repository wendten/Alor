namespace Alor.Web.Models;

public sealed class WorldMapViewModel
{
    public required string WorldName { get; init; }
    public required string Era { get; init; }
    public required string MapImagePath { get; init; }
    public required IReadOnlyList<Location> Locations { get; init; }
}
