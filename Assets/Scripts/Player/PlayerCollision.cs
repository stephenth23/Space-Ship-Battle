using UnityEngine;
using System.Collections;
using System.Threading;

public class PlayerCollision : MonoBehaviour
{
    public GameObject deadMenu;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

            Time.timeScale = 0;
            deadMenu.gameObject.SetActive(true);
        }
    }
}