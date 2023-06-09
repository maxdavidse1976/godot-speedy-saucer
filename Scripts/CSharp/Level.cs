using Godot;
using System;

public partial class Level : Node
{
	private void _on_maze_body_exited(Node2D body)
	{
		GetTree().ReloadCurrentScene();
	}
}



