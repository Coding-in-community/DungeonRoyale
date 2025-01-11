using DungeonRoyale.Shared.Scripts.Constants;

namespace DungeonRoyale.Modules.Player.Scripts;

public partial class Player : CharacterBody2D
{
	[Export] private float MovementSpeed { get; set; } = 200.0f;
	private AnimatedSprite2D _animatedSprite;
	private Direction _currentDirection = Direction.South;

	private const float DIRECTION_THRESHOLD = 0.1f;

	private enum Direction
	{
		North,
		South,
		East,
		West
	}

	private readonly struct AnimationNames
	{
		public const string NorthWalk = "u_walk";
		public const string SouthWalk = "d_walk";
		public const string SideWalk = "s_walk";

		public static string GetIdleAnimation(Direction direction) => direction switch
		{
			Direction.North => "u_idle",
			Direction.South => "d_idle",
			_ => "s_idle"
		};
	}

	public override void _Ready()
	{
		_animatedSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	public override void _Process(double delta)
	{
		var movementDirection = GetMovementDirection();
		UpdateMovement(movementDirection);
		UpdateAnimation(movementDirection);
	}

	public override void _PhysicsProcess(double delta)
	{
		MoveAndSlide();
	}

	private static Vector2 GetMovementDirection()
	{
		return Input.GetVector(
			MappedInputs.Left,
			MappedInputs.Right,
			MappedInputs.Up,
			MappedInputs.Down
		);
	}

	private void UpdateMovement(Vector2 direction)
	{
		Velocity = direction != Vector2.Zero
			? direction * MovementSpeed
			: Vector2.Zero;
	}

	private void UpdateAnimation(Vector2 direction)
	{
		if (direction == Vector2.Zero)
		{
			PlayIdleAnimation();
			return;
		}

		PlayMovementAnimation(direction);
	}

	private void PlayMovementAnimation(Vector2 direction)
	{
		string animation;
		var shouldFlipHorizontally = false;

		if (direction.Y < -DIRECTION_THRESHOLD)
		{
			animation = AnimationNames.NorthWalk;
			_currentDirection = Direction.North;
		}
		else if (direction.Y > DIRECTION_THRESHOLD)
		{
			animation = AnimationNames.SouthWalk;
			_currentDirection = Direction.South;
		}
		else if (direction.X != 0)
		{
			animation = AnimationNames.SideWalk;
			_currentDirection = direction.X > 0 ? Direction.East : Direction.West;
			shouldFlipHorizontally = direction.X > 0;
		}
		else
		{
			return;
		}

		PlayAnimation(animation, shouldFlipHorizontally);
		UpdateAnimationSpeed();
	}

	private void PlayIdleAnimation()
	{
		var idleAnimation = AnimationNames.GetIdleAnimation(_currentDirection);

		if (_animatedSprite.Animation == idleAnimation)
			return;

		PlayAnimation(idleAnimation);
		_animatedSprite.SpeedScale = 1.0f;
	}

	private void PlayAnimation(string animation, bool flipHorizontally = false)
	{
		_animatedSprite.Animation = animation;
		_animatedSprite.FlipH = flipHorizontally;
		_animatedSprite.Play();
	}

	private void UpdateAnimationSpeed()
	{
		_animatedSprite.SpeedScale = Velocity.Length() / MovementSpeed;
	}
}
