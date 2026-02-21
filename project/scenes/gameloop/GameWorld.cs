using Godot;
using System;

public partial class GameWorld : Node2D
{
	private Node2D tokens;
	private PackedScene token;
	private Area2D bottomArea;
	private bool increasePower = true;
	private bool canLaunch = true;
	private bool powerIncreased = false;
	private int power = 0;
	public int tokensLeft = 5;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		token = GD.Load<PackedScene>("res://project/scenes/gameloop/token.tscn");
		tokens = GetNode<Node2D>("Tokens");
		bottomArea = GetNode<Area2D>("BottomArea");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(Input.IsActionPressed("coinlaunch"))
		{
			powerIncreased = true;
			if(power > 1000)
				increasePower = false;
			if(power < 0)
				increasePower = true;

			GD.Print(power);
			if(increasePower)
				power += 5;
			else
				power -= 5;
		}
		if(!Input.IsActionPressed("coinlaunch") && canLaunch && powerIncreased)
		{
			canLaunch = false;
			GD.Print("Launching");
			Token launchingToken = token.Instantiate<Token>();
			launchingToken.GlobalPosition = new Vector2(316, -248.5f);
			bottomArea.BodyEntered += launchingToken._on_area_2d_body_entered;
			tokens.AddChild(launchingToken);
			launchingToken.ApplyImpulse(new Vector2((int)-power, 20 + (int)power), launchingToken.Position);
		}
		if(tokens.GetChildCount() == 0 && !canLaunch)
		{
			power = 0;
			powerIncreased = false;
			canLaunch = true;
		}
	}
}
