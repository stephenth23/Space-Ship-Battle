using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BulletKeepingScore : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            FindObjectOfType<UpdatingScore>().UpdateScore();
        }
    }
}