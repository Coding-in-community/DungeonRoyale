using Godot;

namespace DungeonRoyale.Src.Modules.MainMenu.Scripts;

public partial class InitialScreen : Control
{
    [Export] private PackedScene? _gameScene;
    
    public void OnPlayButtonPressed()
        => GetTree().ChangeSceneToPacked(_gameScene);
}
