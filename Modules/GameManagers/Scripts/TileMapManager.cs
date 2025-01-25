namespace DungeonRoyale.Modules.GameManagers.Scripts;

public partial class TileMapManager : Node2D
{
    public static TileMapManager? Instance { get; private set; }

    public TileMapLayer GroundTileMap { get; private set; } = null!;
    public TileMapLayer SpawnTileMap { get; private set; } = null!;

    public override void _Ready()
    {
        if (Instance is null)
        {
            Instance = this;
        }
        else
        {
            GD.PrintErr("There is already an instance of TileMapManager in the scene.");
        }

        if (GetTree().CurrentScene.FindChild(nameof(GroundTileMap), true) is not TileMapLayer groundTileMap)
        {
            GD.PrintErr("GroundTileMap node not found.");
            return;
        }

        if (GetTree().CurrentScene.FindChild(nameof(SpawnTileMap), true) is not TileMapLayer spawnTileMap)
        {
            GD.PrintErr("SpawnTileMap node not found.");
            return;
        }

        GroundTileMap = groundTileMap;
        SpawnTileMap = spawnTileMap;
    }
}
