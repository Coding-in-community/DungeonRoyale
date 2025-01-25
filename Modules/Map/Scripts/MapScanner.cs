using DungeonRoyale.Modules.GameManagers.Scripts;

namespace DungeonRoyale.Modules.Map.Scripts;

public partial class MapScanner : Node2D 
{
    private TileMapManager _tileMapManager => TileMapManager.Instance!;
    private TilesManager _tilesManager => TilesManager.Instance!;

    [Signal] public delegate void MapScannedEventHandler();

    public void Scan(int width, int height)
    {
        GD.Print("Scanning map...");
        for (int x = 0; x < width; x++)
        for (int y = 0; y < height; y++)
        {
            var groundTile = _tileMapManager.GroundTileMap.GetCellTileData(new Vector2I(x, y));
            
            if (groundTile is null)
                continue;
            
            if (!_tilesManager.TryGetTileAt(x, y, out var tileData))
                continue;

            tileData.IsWalkable = groundTile.GetCustomData("IsWalkable").AsBool();

            var spawnTile = _tileMapManager.SpawnTileMap.GetCellTileData(new Vector2I(x, y));

            if (spawnTile is null)
                continue;

            tileData.IsSpawnPoint = true;
        }

        GD.Print("Map scanned.");
        EmitSignal(SignalName.MapScanned);
    }
}
