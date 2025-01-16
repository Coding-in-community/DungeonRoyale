using DungeonRoyale.Modules.GameManagers.Scripts;
using DungeonRoyale.Modules.Map.Scripts;

namespace DungeonRoyale.Modules.Game.Scripts;

public partial class Game : Node2D
{
    private static TilesManager _tilesManager => TilesManager.Instance!;

    [Export] public MapSettingsResource MapSettings { get; private set; } = new MapSettingsResource();

    private bool MapIsLoading { get; set; } = true;

    public override void _Ready()
    {
        _tilesManager.SetUpTiles(MapSettings.Width, MapSettings.Height);
    }

    public void OnMapScanned()
    {
        MapIsLoading = false;

        // Do something with the scanned map
    }

    public void OnMapGenerated()
    {
        MapIsLoading = false;

        // Do something with the generated map
    }
}
