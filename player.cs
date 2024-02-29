using Godot;
using System;





public partial class player : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float JumpVelocity = -400.0f;
	


	// Get the gravity from the project settings to be synced with RigidBody nodes.
	public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
			velocity.Y += gravity * (float)delta;

		// Handle Jump.
		if (Input.IsActionJustPressed("ui_accept") && IsOnFloor())
			velocity.Y = JumpVelocity;
			((AnimationPlayer)GetNode("AnimationPlayer")).Play("Jump");

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		if (direction != Vector2.Zero)
		{
			// IF direction is -1 or 1
			if (direction == Vector2.One){
				//get_node("CharCss").flip_h = true
				Sprite2D sp = ((Sprite2D)GetNode("CharCss"));
				sp.FlipH = true;
			}
			
			
			velocity.X = direction.X * Speed;
			if (velocity.Y == 0){
				Parse p = new Parse("G","CharCss");
				((AnimationPlayer)GetNode("AnimationPlayer")).Play("Run");
			}
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
			if (velocity.Y == 0){
				((AnimationPlayer)GetNode("AnimationPlayer")).Play("Idle");
			}
		}

		Velocity = velocity;
		MoveAndSlide();
	}
}
