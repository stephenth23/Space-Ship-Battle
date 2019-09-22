using UnityEngine;
using System.Collections;

public class EnemyRedMovement : MonoBehaviour
{
    Rigidbody2D rigidbody;

    public float moveSpeed = 3f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(-moveSpeed, 0);

        DestroyTheEnemy();
    }

    //---------------------------------------------
    void DestroyTheEnemy()
    {
        if (transform.position.x <= -10f)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Trigger"))
            FindObjectOfType<UpdatingLives>().UpdateLives();
    }
}