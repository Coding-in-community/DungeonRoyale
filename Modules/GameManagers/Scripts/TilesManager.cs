using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using DungeonRoyale.Modules.Tiles.Scripts;

namespace DungeonRoyale.Modules.GameManagers.Scripts;

public partial class TilesManager : Node2D
{
    public static TilesManager? Instance { get; private set; }

    public DRTileData[,] Tiles { get; private set; } = new DRTileData[0, 0];

    private int _width;
    private int _height;

    public override void _Ready()
    {
        if (Instance is null)
        {
            Instance = this;
        }
        else
        {
            GD.PrintErr("There is already an instance of TilesManager in the scene.");
        }
    }


    public void SetUpTiles(int width, int height)
    {
        _width = width;
        _height = height;

        Tiles = new DRTileData[_width, _height];

        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                Tiles[x, y] = new DRTileData(x, y, true, false);
            }
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private bool IsOutOfMapBounds(int x, int y) =>
        x < 0 || x >= _width || y < 0 || y >= _height;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public DRTileData? GetTileAt(int x, int y) =>
        IsOutOfMapBounds(x, y) ? null : Tiles[x, y];

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryGetTileAt(int x, int y, [NotNullWhen(returnValue: true)] out DRTileData? tileData) =>
        (tileData = GetTileAt(x, y)) is not null;
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryGetTileAt((int x, int y) position, [NotNullWhen(returnValue: true)] out DRTileData? tileData) =>
        TryGetTileAt(position.x, position.y, out tileData);
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryGetTileAt(Vector2I position, [NotNullWhen(returnValue: true)] out DRTileData? tileData) =>
        TryGetTileAt(position.X, position.Y, out tileData);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryGetTileAtGlobalCoords(Vector2 position, [NotNullWhen(returnValue: true)] out DRTileData? tileData) =>
        (tileData = GetTileAt((int) position.X / TileConstants.TILE_SIZE, (int) position.Y / TileConstants.TILE_SIZE)) is not null;
}
