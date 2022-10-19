using UnityEngine;

public class Player : Human
{
    [SerializeField] private float speed;

    protected override void InitBehaviors()
    {
        movable = new InputMoveBehaviour(GetComponent<Rigidbody2D>(), speed);
    }

    private void FixedUpdate()
    {
        Move();
    }
}