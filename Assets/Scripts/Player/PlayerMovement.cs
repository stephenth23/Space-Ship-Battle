using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidbody;

    public float moveSpeed = 10f;
    public float mapHeight = 2f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical") * Time.fixedDeltaTime * moveSpeed;

        Vector2 position = rigidbody.position + Vector2.up * moveVertical;
        position.y = Mathf.Clamp(position.y, -mapHeight, mapHeight);
        rigidbody.MovePosition(position);
    }
}