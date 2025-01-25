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

        var tileMapLayers = this.GetRecursivelyNodesOfType<TileMapLayer>();

        foreach (var tileMapLayer in tileMapLayers)
        {
            if (tileMapLayer.Name == nameof(GroundTileMap))
            {
                GroundTileMap = tileMapLayer;
            }
            else if (tileMapLayer.Name == nameof(SpawnTileMap))
            {
                SpawnTileMap = tileMapLayer;
            }
        }

        if (GroundTileMap is null || SpawnTileMap is null)
        {
            GD.PrintErr("TileMapLayers not found.");
        }
    }
}
