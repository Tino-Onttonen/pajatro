using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class Token : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	public void _on_area_2d_body_entered(Node2D node)
	{
		GD.Print("Dying");
		this.Visible = false;
		QueueFree();
	}
}
