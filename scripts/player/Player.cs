using Godot;
using System;

public class Player : Node
{

    [Export] protected string name;
    protected string uid;
    protected float maxSpeed = 400;
    protected float speed;
    protected int acceleration = 1200;
    protected float moveDirection;
    protected bool isMoving = false;
    protected Vector2 destination = new Vector2();
    protected Vector2 velocity = new Vector2();

    protected KinematicBody playerBody;

    public override void _Ready()
    {
        playerBody = GetNode<KinematicBody>("KinematicBody");
    }

    public override void _UnhandledInput(InputEvent @event)
    {
        if (@event.IsActionPressed("ui_left_click"))
        {
            isMoving = true;
            destination = GetViewport().GetMousePosition();
        }
    }

    public override void _Process(float delta)
    {

    }

    public override void _PhysicsProcess(float delta)
    {
        MoveHandler(delta);
    }

    protected virtual void MoveHandler(float delta)
    {
        if (!isMoving) speed = 0;
        else
        {
            speed += acceleration * delta;
            if (speed > maxSpeed) speed = maxSpeed;
        }
        //playerBody.GetPositionInParent.Direc
        //velocity = playerBody.Position.DirectionTo(destination) * speed;
        //moveDirection = Mathf.Rad2Deg(destination.AngleToPoint(playerBody.Position));
        //if (playerBody.Position.DistanceTo(destination) > 5)
        //    velocity = 
    }

    
}
