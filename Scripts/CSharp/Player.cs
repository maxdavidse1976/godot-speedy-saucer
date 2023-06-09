using Godot;
using System;

public partial class Player : RigidBody2D
{
	private int force = 1000;

	public override void _PhysicsProcess(double delta)
	{
		if (Input.IsActionPressed("move_right"))
		{
			ApplyForce(new Vector2(force, 0));
		}
		if (Input.IsActionPressed("move_left"))
		{
			ApplyForce(new Vector2(-force, 0));
		}
		if (Input.IsActionPressed("move_up"))
		{
			ApplyForce(new Vector2(0, -force));
		}
		if (Input.IsActionPressed("move_down"))
		{
			ApplyForce(new Vector2(0, force));
		}
	}
}
