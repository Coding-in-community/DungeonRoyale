namespace DungeonRoyale.Modules.Map.Scripts;

public partial class MapScanner : Node2D 
{
    [Signal] public delegate void MapScannedEventHandler();

    public override void _Ready()
    {
        EmitSignal(SignalName.MapScanned);
    }
}
