using UnityEngine;
using System.Collections;

public class EnemyBlueHealth : MonoBehaviour
{
    int health = 2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            health--;

            if (health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}