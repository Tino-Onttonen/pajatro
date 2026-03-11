using Godot;
using System;

public partial class Board : StaticBody2D
{
	public int score = 0;

	[Signal]
	public delegate void ScoreChangedEventHandler(int scr);
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var Slots = GetNode<Node2D>("Slots");

		foreach(Area2D child in Slots.GetChildren())
		{
			if(child.EditorDescription == "50")
			{
				child.BodyEntered += (body) => {setScore(score + 50);};
				GD.Print("50 signal added");
			}
			else if(child.EditorDescription == "20")
			{
				child.BodyEntered += (body) => {setScore(score + 20);};
				GD.Print("20 signal added");
			}
			else if(child.EditorDescription == "10")
			{
				child.BodyEntered += (body) => {setScore(score + 10);};
				GD.Print("10 signal added");
			}
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}

	private void setScore(int value)
	{
		score = value;
		EmitSignal(SignalName.ScoreChanged, score);
	}
}
