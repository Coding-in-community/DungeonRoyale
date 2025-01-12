using DungeonRoyale.Modules.GameManagers.Scripts;

namespace DungeonRoyale.Modules.Game.Scripts;

public partial class Game : Node2D
{
    private static TilesManager _tilesManager => TilesManager.Instance!;

    [Export] public int MapWidth { get; private set; }
    [Export] public int MapHeight { get; private set; }

    private bool MapIsLoading { get; set; } = true;

    public override void _Ready()
    {
        _tilesManager.SetUpTiles(MapWidth, MapHeight);
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
