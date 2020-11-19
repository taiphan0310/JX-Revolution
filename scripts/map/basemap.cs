using Godot;
using System;

public class basemap : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	
	public Sprite character;
	public Navigation2D navigate2D;
	public Line2D line2D;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		character = GetNode<Sprite>("Sprite");
		navigate2D = GetNode<Navigation2D>("Navigation2D");
		line2D = GetNode<Line2D>("Line2D");
	}
	
	public override void _UnhandledInput(InputEvent @event){

        if (@event is InputEventMouse eventKey)
        {
        //    if (eventKey.IsPressed  )
        //    {

        //    }
        }
        
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
