namespace DungeonRoyale.Modules.Map.Scripts;

public partial class MapSettingsResource : Resource
{
    [Export] public int Width { get; private set; } = 100;
    [Export] public int Height { get; private set; } = 100;
}
