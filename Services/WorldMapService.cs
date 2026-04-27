using Alor.Web.Models;

namespace Alor.Web.Services;

public sealed class WorldMapService : IWorldMapService
{
    public WorldMapViewModel GetWorld()
    {
        return new WorldMapViewModel
        {
            WorldName = "Alor",
            Era = "Fifth Age of Embers",
            MapImagePath = "/images/alor-map.svg",
            Locations =
            [
                new Location
                {
                    Name = "Asterhold",
                    Region = "Northreach",
                    Type = "Capital City",
                    Description = "Seat of the Sun Crown and largest trade port in the north.",
                    X = 67.5,
                    Y = 27.0
                },
                new Location
                {
                    Name = "Whisperfen",
                    Region = "The Mirelands",
                    Type = "Swamp",
                    Description = "A labyrinth of bioluminescent marshes haunted by ancient spirits.",
                    X = 43.2,
                    Y = 62.1
                },
                new Location
                {
                    Name = "Ironspine",
                    Region = "Ashen Range",
                    Type = "Mountain Fortress",
                    Description = "Dwarven stronghold carved directly into volcanic stone.",
                    X = 23.8,
                    Y = 35.4
                },
                new Location
                {
                    Name = "Moonmirror Lake",
                    Region = "Silverwild",
                    Type = "Sacred Site",
                    Description = "A crystal lake said to reveal fragments of possible futures.",
                    X = 58.1,
                    Y = 48.7
                },
                new Location
                {
                    Name = "Cinderfall Gate",
                    Region = "Shattered South",
                    Type = "Ruins",
                    Description = "Collapsed titan gate left from the era before recorded history.",
                    X = 76.4,
                    Y = 73.6
                }
            ]
        };
    }
}
