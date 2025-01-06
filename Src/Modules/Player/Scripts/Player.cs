using DungeonRoyale.Shared.Scripts;
namespace DungeonRoyale.Modules.Player.Scripts;

public partial class Player : CharacterBody2D
{
    [Export] private float _speed = 400f;

    public override void _Process(double delta)
    {
        var direction = Input.GetVector(MappedInputs.Left, MappedInputs.Right, MappedInputs.Up, MappedInputs.Down);

        Velocity = direction * _speed;
    }

    public override void _PhysicsProcess(double delta)
    {
        MoveAndSlide();
    }
}
