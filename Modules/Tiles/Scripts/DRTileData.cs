namespace DungeonRoyale.Modules.Tiles.Scripts;

public partial class DRTileData
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public bool IsWalkable { get; private set; }

    public bool IsSpawnPoint { get; private set; }

    public DRTileData()
    {
    }

    public DRTileData(int x, int y, bool isWalkable, bool isSpawnPoint)
    {
        X = x;
        Y = y;
        IsWalkable = isWalkable;
        IsSpawnPoint = isSpawnPoint;
    }
}
