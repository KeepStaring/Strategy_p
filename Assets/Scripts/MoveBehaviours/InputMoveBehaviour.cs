using UnityEngine;

public class InputMoveBehaviour : IMovable
{
    private Rigidbody2D rigidBody;

    private float speed;

    public InputMoveBehaviour(Rigidbody2D rigidBody, float speed)
    {
        this.rigidBody = rigidBody;
        this.speed = speed;
    }

    public void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        rigidBody.velocity = new Vector2(moveHorizontal * speed, rigidBody.velocity.y);
    }

    public void SetMoveSpeed(float speed) => this.speed = speed;
}