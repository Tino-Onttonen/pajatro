using Godot;
using System;

public partial class Hud : Control
{
	public int score = 0;
	private Label scoreTextLabel;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		scoreTextLabel = GetNode<Label>("ScoreText");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	public void addScore(int value)
	{
		score += value;
		updateScoreText("Score : " + score);
	}

	private void updateScoreText(String text)
	{
		scoreTextLabel.Text = text;
	}
}
