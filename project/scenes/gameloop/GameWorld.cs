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
	private Marker2D tokenSpawnPoint;
	private Board board;
	private Hud hud;
	public int tokensLeft = 5;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		token = GD.Load<PackedScene>("res://project/scenes/gameloop/token.tscn");
		tokens = GetNode<Node2D>("Tokens");
		bottomArea = GetNode<Area2D>("BottomArea");
		tokenSpawnPoint = GetNode<Marker2D>("TokenSpawnPoint");
		board = GetNode<Board>("Board");
		hud = GetNode<Hud>("Hud");


		board.ScoreChanged += (score) => {hud.updateScoreText("Score: " + score.ToString());};
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//Cycles "power" from 0 to 1000 as long as "coinlaunch" action is pressed
		if(Input.IsActionPressed("coinlaunch") && canLaunch)
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
		//When the "coinlaunch" action is pressed and released, coin is launched
		if(!Input.IsActionPressed("coinlaunch") && canLaunch && powerIncreased)
		{
			canLaunch = false;
			powerIncreased = false;
			GD.Print("Launching");
			launchToken();
		}
		//If there is no tokens in the game world, "canLaunch" is set to true
		if(tokens.GetChildCount() == 0 && !canLaunch)
		{
			power = 0;
			canLaunch = true;
		}
	}

	private void launchToken() //new token is instantiated, positioned to "tokenSpawnPoint" and launched by applying impulse to it
	{
		Token launchingToken = token.Instantiate<Token>();
		launchingToken.Position = tokenSpawnPoint.Position;
		launchingToken.Scale = new Vector2(0.8f, 0.8f);
			
		bottomArea.BodyEntered += launchingToken._on_area_2d_body_entered;
		tokens.AddChild(launchingToken);
		launchingToken.ApplyImpulse(new Vector2((int)-power, (int)-power), launchingToken.Position);
	}
}
