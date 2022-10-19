using UnityEngine;

public abstract class Human : MonoBehaviour
{
    protected IMovable movable;

    protected abstract void InitBehaviors();

    protected void ChangeMoving(IMovable movable) => this.movable = movable;

    private void Awake()
    {
        InitBehaviors();
    }

    protected void Move()
    {
        movable.Move();
    }
}