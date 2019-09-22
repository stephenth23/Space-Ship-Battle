using UnityEngine;
using System.Collections;

public class BulletDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
            Destroy(gameObject);
    }
}
