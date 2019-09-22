using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour
{
    Rigidbody2D rigidbody;

    public float moveSpeed = 10f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(moveSpeed, 0);

        DestroyTheBullet();
    }

    // Destroying the bullet from Hierarchy
    void DestroyTheBullet()
    {
        if (transform.position.x >= 9.2f)
            Destroy(gameObject);
    }
}
