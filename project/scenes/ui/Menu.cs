using Godot;
using System;

public partial class Menu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}


	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	// Settings button pressed -> open settings & turn panel visible
	public void _on_settings_button_pressed()
	{
		GetNode<PanelContainer>("settingsMenu").Visible = true;
	}

	// Play-button pressed -> change scene to gameloop
	public void _on_play_button_pressed()
	{
  		GetTree().ChangeSceneToFile("res://gameloop.tscn");
	}
	public void _on_return_button_pressed()
	{
		GetNode<PanelContainer>("settingsMenu").Visible = false;
	}
}
