using Godot;
using System;

public class Camera : Godot.Camera
{
    protected Camera camera;
    protected Sprite player;
    protected Node root;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        root = GetNode<Node>("/root/Game");
        camera = GetNode<Camera>("Camera");
        player = root.GetNode<Sprite>("MainPlayer/Sprite");
        GD.Print(player);
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
