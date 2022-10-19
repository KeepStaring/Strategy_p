using UnityEngine;

public class Enemy : Human
{
    [SerializeField] private Transform[] patrolPoints;

    [SerializeField] private float speed;

    protected override void InitBehaviors()
    {
        movable = new PatrolMoveBehaviour(GetComponent<Rigidbody2D>(), patrolPoints, speed); ;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
            if (movable is PatrolMoveBehaviour)
                ChangeMoving(new NoMoveBehaviour());
    }
}