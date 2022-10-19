using UnityEngine;

public class PatrolMoveBehaviour : IMovable
{
    private Rigidbody2D rigidBody;
    private Transform[] patrolPoints;

    private System.Random random = new System.Random();

    private int currentRandomPoint;
    private int previousRandomPoint;

    private int directionMovement;

    private float speed;

    public PatrolMoveBehaviour(Rigidbody2D rigidBody, Transform[] patrolPoints, float speed)
    {
        this.rigidBody = rigidBody;
        this.patrolPoints = patrolPoints;
        this.speed = speed;

        SearchRandomPoint();
    }

    public void Move()
    {
        rigidBody.velocity = new Vector2(directionMovement * speed, rigidBody.velocity.y);

        if (Mathf.Abs(patrolPoints[currentRandomPoint].position.x - rigidBody.position.x) < 0.2f)
            SearchRandomPoint();
    }

    public void SetMoveSpeed(float speed) => this.speed = speed;

    private void SearchRandomPoint()
    {
        currentRandomPoint = random.RandomNumber(patrolPoints.Length, previousRandomPoint);
        previousRandomPoint = currentRandomPoint;

        DirectionCalculation();
    }

    private void DirectionCalculation() => directionMovement = patrolPoints[currentRandomPoint].position.x > rigidBody.position.x ? 1 : -1;
}